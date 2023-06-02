using Application.DTOs.Users;
using Application.Extencions;
using Application.Interfaces.ServiceInterfaces;
using Application.Models;
using Application.ResponceModel;
using AutoMapper;
using Domain.Entities.Models;
using Domain.Tokens;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Pharmacy.Filters;
using Serilog;
using SolrNet.Utils;

namespace Pharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly IValidator<User> _validator;

        protected IMapper _mapper => HttpContext.RequestServices.GetRequiredService<IMapper>();

        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public UserController(IUserService userService, ITokenService tokenService, IValidator<User> validator)
        {
            _userService = userService;
            _tokenService = tokenService;
            _validator = validator;
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<ActionResult<ResponseCore<UserCreateDTO>>> CreateUser([FromBody] UserCreateDTO userDto)
        {
            userDto.Password = userDto.Password.stringHash()!;
            User user = _mapper.Map<User>(userDto);
            var validationResult = _validator.Validate(user);

            if (!validationResult.IsValid)
            {
                return BadRequest(new ResponseCore<UserCreateDTO>(false, validationResult.Errors));
            }
            User resultUser = await _userService.AddAsync(user);
            UserCreateDTO result = _mapper.Map<UserCreateDTO>(resultUser);
            return Ok(new ResponseCore<UserCreateDTO>() { IsSuccess = true, Result = result });
        }


        [HttpPost("[action]")]
        [ModelValidationAttribute]
        [AllowAnonymous]
        public async Task<ActionResult<ResponseCore<Token>>> LoginUser([FromBody] UserCredential userCredential)
        {
            userCredential.Password = userCredential.Password.stringHash()!;
            User? user = (await _userService.GetAll(x => true)).FirstOrDefault(x =>x.Password == userCredential.Password);
            Log.Warning("This is Warning!");
            if (user == null)
            {
                return BadRequest(new ResponseCore<UserCreateDTO>(false, "User not found"));
            }
            Token token = new()
            {
                AccessToken = await _tokenService.CreateAccesToken(user!),
                RefreshToken = await _tokenService.CreateRefreshAccesToken(user!)
            };
            return Ok(new ResponseCore<Token>() { IsSuccess = true, Result = token });
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("Refresh")]
        public async Task<IActionResult> Refresh([FromBody] Token tokens)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(tokens.AccessToken);
            string? username = principal.Identity?.Name;
            if (username == null)
            {
                return BadRequest("Refresh Token not found");
            }
            RefreshToken? savedrefreshToken = _tokenService.Get(x => x.Username == username &&
                                                                x.RefreshTokenValue == tokens.RefreshToken).FirstOrDefault();
            if(savedrefreshToken == null)
            {
                return BadRequest("Refresh token or Acces token invalid");
            }
            if(savedrefreshToken.ExpiredDate<DateTime.UtcNow) 
            {

                _tokenService.Delete(savedrefreshToken);
                return StatusCode(405, "Refresh token already expired");
            }
            Token newTokens = await _tokenService.CreateTokensFromRefresh(principal, savedrefreshToken);

            return Ok(newTokens);
        }
    }
}

