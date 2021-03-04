using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Entity;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Core.ValidationTools;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarServiceManager : ICarService
    {

        ICarDal _carDal;

        public CarServiceManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.Getall(), true, MessagesSuccess.CarsListed);

           
        }

        public IDataResult<List<Car>> GetByBrandId(int ıd)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetByBrandId(c=>c.BrandId==ıd),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Car>> GetByCategoryId(int ıd)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetByCategoryId(c=>c.CategoryId==ıd),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Car>> GetByColorId(int ıd)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetByColorId(c=>c.ColorId==ıd),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(c=>c.Id==Id),true,MessagesSuccess.CarsListed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }
    }
}
