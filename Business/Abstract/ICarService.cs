using Core.DataAccess.Abstract;
using Core.Entity;
using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(string Id);

        IDataResult<List<Car>> GetByColorId(string ıd);
        IDataResult<List<Car>> GetByBrandId(string ıd);
        IDataResult<List<Car>> GetByCategoryId(string ıd);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);



    }
}
