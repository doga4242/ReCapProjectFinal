using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentCarServiceManager : IRentCarService
    {
        IRentalDal _rentalDal;

        public RentCarServiceManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentedCarValidator))]
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            

            return new SuccessDataResult<List<Rental>>(_rentalDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetById(i => i.Id == id), true, MessagesSuccess.CarsListed);
        }

        public IDataResult<Rental> GetRentalByCustomerId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetById(i => i.CustomerId == id), true, MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Rental>> GetRentedCarDetails(int id)
        {


            return new SuccessDataResult<List<Rental>>(_rentalDal.GetRentedCarDetails(i=>i.Id==id), true, MessagesSuccess.CarsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }
    }
}
