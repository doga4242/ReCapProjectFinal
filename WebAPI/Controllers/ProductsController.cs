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
    public class ProductsController : ControllerBase
    {

        ICarService _carServiceManager; 

        public ProductsController(ICarService carService)
        {
            _carServiceManager = carService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carServiceManager.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
                return BadRequest(result.Masseges);

    
        }
        [HttpGet("getbyid")]
        public IActionResult Get(string Id)
        {
            var result = _carServiceManager.GetById(Id);

            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Masseges);
        }
        [HttpPost("add")]
        public IActionResult Post(Car car)
        {

            var result = _carServiceManager.Add(car);

            if (result.Success)
            {
                return Ok(result);
            }
            else
              return BadRequest(result);

        }

    }

}
