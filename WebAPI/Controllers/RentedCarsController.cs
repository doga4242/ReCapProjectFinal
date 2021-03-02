using Business.Abstract;
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
    public class RentedCarsController : ControllerBase

    {
        IRentCarService _rentCarService;

        public RentedCarsController(IRentCarService rentCarService)
        {
            _rentCarService = rentCarService;
        }

        [HttpGet("getrentals")]
        public IActionResult Get()
        {
            var result = _rentCarService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
                return BadRequest(result.Masseges);
        }

        [HttpPost("rentaladd")]
        public IActionResult Post(Rental rentedCar)
        {
            var result = _rentCarService.Add(rentedCar);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpGet("getrentedcardetails")]
        public IActionResult Get(string Id)
        {
            var result = _rentCarService.GetRentedCarDetails(Id);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
                return BadRequest(result.Data);
        }
    }
}
