using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using WorkLath.Service.Services;

namespace WorkLath.Controllers
{
    public class UsersController : BaseController<Users, UsersDto>
    {
        private readonly IUserService _userService;
        public UsersController(IUserService service) : base(service)
        {
            _userService = service;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticateRequestDto model)
        {
            var response = await _userService.GetToken(model);

            if (response is null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
