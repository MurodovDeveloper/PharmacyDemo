using Application.DTOs.Categories;
using Application.DTOs.Commentaries;
using Application.DTOs.Drugs;
using Application.DTOs.Permissions;
using Application.DTOs.Roles;
using Application.DTOs.Users;
using AutoMapper;
using Domain.Entities.IdentityEntities;
using Domain.Entities.Models;

namespace Application.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            DrugMapping();



            CategoryMapping();

            UserMapping();

            PermissionMapping();

            void DrugMapping()
            {
                CreateMap<DrugCreateDTO, Drug>().ReverseMap();
                CreateMap<DrugUpdateDTO, Drug>().ReverseMap();
                CreateMap<DrugGetDTO, Drug>().ReverseMap();

            }


            void PermissionMapping()
            {
                CreateMap<PermissionGetDTO, Permission>().ReverseMap();
            }

            void UserMapping()
            {
                CreateMap<UserCreateDTO, User>().ReverseMap();
                CreateMap<UserUpdateDTO, User>().ReverseMap();
                CreateMap<UserGetDTO, User>().ReverseMap();
            }

            void CategoryMapping()
            {

                CreateMap<CategoryCreateDTO, Category>().ReverseMap();
                CreateMap<CategoryUpdateDTO, Category>().ReverseMap();
                CreateMap<CategoryGetDTO, Category>().ReverseMap();

                void RoleMapping()
                {
                    CreateMap<RoleCreateDTO, Role>().ReverseMap();
                    CreateMap<RoleUpdateDTO, Role>().ReverseMap();
                    CreateMap<RoleGetDTO, Role>().ReverseMap();
                }

                void CommentaryMapping()
                {
                    CreateMap<CommentaryCreateDTO, Commentary>().ReverseMap();
                    CreateMap<CommentaryUpdateDTO, Commentary>().ReverseMap();
                    CreateMap<CommentaryGetDTO, Commentary>().ReverseMap();
                }
            }

        }
    }
}


