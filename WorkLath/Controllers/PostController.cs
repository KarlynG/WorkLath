using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using WorkLath.Service.Services;

namespace WorkLath.Controllers
{
    public class PostController : BaseController<Post, PostDto>
    {
        private readonly IPostService _service;
        public PostController(IPostService service) : base(service)
        {
            _service = service;
        }
        [HttpGet("PostByJobId/{id}")]
        public async Task<IEnumerable<PostDto>> GetPostByJobId(int id)
        {
            var query = _service.AsQuery().Where(post => post.JobId == id);
            var result = await _service.ProjectToDto(query);
            return result;
        }
    }
}
