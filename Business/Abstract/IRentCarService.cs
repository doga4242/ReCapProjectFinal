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
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);


        IDataResult<Rental> GetRentalByCustomerId(int id);
        IDataResult<List<DetailRental>> GetRentedCarDetails(int id,DetailRental rental);

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}