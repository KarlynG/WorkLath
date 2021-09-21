using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Context;
using WorkLath.Model.Entities;
using WorkLath.Service.Repository;

namespace WorkLath.Model.Repository
{
    public interface IUserRepository : IBaseRepository<Users> { }
    public class UserRepository : BaseRepository<Users>, IUserRepository 
    {
        public UserRepository(WorkLathContext context) : base(context)
        {
        }

    }
}
