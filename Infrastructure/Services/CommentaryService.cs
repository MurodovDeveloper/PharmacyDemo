using Application.Abstraction;
using Application.Interfaces.ServiceInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CommentarySerivce : Repository<Commentary>, ICommentaryService
    {
        private readonly IApplicatonDbcontext _db;

        public CommentarySerivce(IApplicatonDbcontext db) : base(db)
        {
            _db = db;
        }
    }
    }
