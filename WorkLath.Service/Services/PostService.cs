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
        public interface IPostService : IBaseService<Post, PostDto> { }
        public class PostService : BaseService<Post, PostDto>, IPostService
        {
            public PostService(
                IPostRepository repository,
                IMapper mapper,
                IValidator<PostDto> validator) : base(repository, mapper, validator)
            {
            }
        }
    
}
