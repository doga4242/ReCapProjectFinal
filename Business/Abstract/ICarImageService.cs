using Core.Utilities.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IDataResult<List<CarImage>> Get();

        IResult Add(IFormFile file,CarImage carImage);
        IResult Delete(IFormFile file,CarImage carImage);
        IResult Update(IFormFile file,CarImage carImage);

        IDataResult<CarImage> GetCarImageByCarId(int id);

    }
}
