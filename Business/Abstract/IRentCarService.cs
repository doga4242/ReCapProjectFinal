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
        IResult Add(Rental rentedCar);
        IResult Delete(Rental rentedCar);
        IResult Update(Rental rentedCar);

        IDataResult<List<Rental>> GetAll();
        IDataResult<List<DetailRental>> GetRentedCarDetails(string Id);

    }
}
