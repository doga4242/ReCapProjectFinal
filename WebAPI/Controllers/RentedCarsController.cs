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
    public class RentedCarsController : ControllerBase

    {
        IRentCarService _rentCarService;
       

        public RentedCarsController(IRentCarService rentCarService)
        {
            _rentCarService = rentCarService;
        }

      

        [HttpGet("getrentals")]
        public IActionResult GetRentals()
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
        public IActionResult PostAdd(Rental rentedCar)
        {
            var result = _rentCarService.Add(rentedCar);

            if (result.Success)
            {
                return Ok(result.Masseges);
            }
            else
            {
                return BadRequest(result.Masseges);
            }

        }

        [HttpGet("getrentedcardetails")]
        public IActionResult GetDetails(int Id,DetailRental rental)
        {
            var result = _rentCarService.GetRentedCarDetails(Id,rental);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
                return BadRequest(result.Data);
        }
        [HttpGet("getbyıd")]
        public IActionResult GetById(int id)
        {
            var result = _rentCarService.GetById(id);

            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Masseges);

        }
    }
}
