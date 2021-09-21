using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using WorkLath.Model.Repository;

namespace WorkLath.Service.Services
{
    public interface IUserService : IBaseService<Users, UsersDto> { }
    public class UserService : BaseService<Users, UsersDto>, IUserService
    {
        public UserService(
            IUserRepository repository,
            IMapper mapper,
            IValidator<UsersDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
