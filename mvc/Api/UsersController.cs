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

        /// <summary>
        /// Get user list with pagination
        /// </summary>
        /// <param name="pIndex">Page index</param>
        /// <param name="pSize">Page size</param>
        /// <returns>List of users</returns>
        [HttpGet]
        [Route("")]
        public IActionResult GetUsers([FromQuery] int pIndex, [FromQuery] int pSize)
        {
            var response = _userService.GetUsers(pIndex, pSize);

            return Ok(response);
        }

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>User</returns>
        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUser(int userId)
        {
            var response = _userService.GetUser(userId);

            return Ok(response);
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="model">User create model</param>
        /// <returns>Created user</returns>
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
