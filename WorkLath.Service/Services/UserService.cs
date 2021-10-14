using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WorkLath.Bl.Dto;
using WorkLath.Bl.Extensions;
using WorkLath.Core.Abstract;
using WorkLath.Core.Settings;
using WorkLath.Model.Entities;
using WorkLath.Model.Repository;
using BC = BCrypt.Net.BCrypt;

namespace WorkLath.Service.Services
{
    
    public interface IUserService : IBaseService<Users, UsersDto> {
        Task<AuthenticateResponseDto> GetToken(AuthenticateRequestDto model);
    }
    public class UserService : BaseService<Users, UsersDto>, IUserService
    {
        private readonly JwtSettings _jwtSettings;
        public UserService(
            IUserRepository repository,
            IMapper mapper,
            IValidator<UsersDto> validator,
            IOptions<JwtSettings> jwtSettings) : base(repository, mapper, validator)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public override async Task<IEntityOperationResult<UsersDto>> AddAsync(UsersDto dto)
        {
            Users entity =_mapper.Map<Users>(dto);

            entity.Password = encodepassword(dto.Password);

            var entityResult = await _repository.Add(entity);

            _mapper.Map(entityResult, dto);

            var result = dto.ToOperationResult();

            return result;
            
        }

        //public override async Task<IEntityOperationResult<Users>> AddAsync(UsersDto dto)
        //{


        //    //Users entity = _mapper.Map<Users>(dto);
        //    //entity.Password = encodepassword(dto.Password);

        //    //var entityResult = await _repository.Add(entity);

        //    //_mapper.Map(entityResult, dto);

        //    //var result = dto.ToOperationResult();

        //    //return result;

        //}



        public async Task<AuthenticateResponseDto> GetToken(AuthenticateRequestDto model)
        {
            var user = await _repository.Query()
                .Where(x => x.UserName == model.Username)
                .Select(x => new
                {
                    x.Id,
                    x.UserName,
                    x.Name,
                    x.LastName,
                    x.Password
                })
                .FirstOrDefaultAsync();

            if (user is null)
                return null;


            

            

                        
            
            var isValidPassword = BC.Verify(user.Password, model.Password);

            

            if (isValidPassword is false)
                return null;

            

            var response = new AuthenticateResponseDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Name = user.Name,
                LastName = user.LastName
            };

            response.Token = GenerateJwtToken(response);

            return response;
        }

        

        private string GenerateJwtToken(AuthenticateResponseDto user)
        {
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);

            var symmetricSecurityKey = new SymmetricSecurityKey(key);

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var claimsIdentity = new ClaimsIdentity(new[] {
                new Claim("id", user.Id.ToString()),
                new Claim("username",user.UserName)
            });

            var claims = new Dictionary<string, object>
            {
                { "name", user.Name },
                { "lastName", user.LastName },
            };

            var description = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Claims = claims,
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiresInMinutes),
                SigningCredentials = signingCredentials
            };

            var handler = new JwtSecurityTokenHandler();

            var securityToken = handler.CreateToken(description);

            var token = handler.WriteToken(securityToken);

            return token;
        }
        private string encodepassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }
        
    }
}
