using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface IRentCarService
    {
        IResult Add(RentedCar rentedCar);
        IResult Delete(RentedCar rentedCar);
        IResult Update(RentedCar rentedCar);

        IDataResult<List<RentedCar>> GetAll();

    }
}
