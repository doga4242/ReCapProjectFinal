using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract.IEframework;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getusers")]
        public IActionResult Get()
        {
            var result = _userService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
              return BadRequest(result.Masseges);

        }

        [HttpPost("signin")]
        public IActionResult Post(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
    }
}
