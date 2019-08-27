using System;
using Microsoft.AspNetCore.Mvc;
using mvc.Interfaces;
using mvc.Models.Requests;

namespace mvc.Api
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUser(int userId)
        {
            var response = _userService.GetUser(userId);

            return Ok(response);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateUser([FromBody] CreateUserRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var response = _userService.CreateUser(model);

                return Ok(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }
    }
}
