using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentCarServiceManager : IRentCarService
    {
        IRentCarService _rentCarService;

        public RentCarServiceManager(IRentCarService rentCarService)
        {
            _rentCarService = rentCarService;
        }
         
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(RentedCar rentedCar)
        {
            

            if ((rentedCar.ReturnDate) != null)
            {
                _rentCarService.Add(rentedCar);

                return new SuccessResult();
            }
            else
                return new ErrorResult();
   
        }

        public IResult Delete(RentedCar rentedCar)
        {
            _rentCarService.Delete(rentedCar);

            return new SuccessResult();
        }

        public IDataResult<List<RentedCar>> GetAll()
        {
            _rentCarService.GetAll();

            return new SuccessDataResult<List<RentedCar>>();
        }

        public IResult Update(RentedCar rentedCar)
        {
            _rentCarService.Update(rentedCar);

            return new SuccessResult();
        }
    }
}
