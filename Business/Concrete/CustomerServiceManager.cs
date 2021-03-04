using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerServiceManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerServiceManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            

            return new SuccessDataResult<List<Customer>>(_customerDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<Customer> GetById(int Id)
        {
            

            return new SuccessDataResult<Customer>(_customerDal.GetById(i => i.UserId == Id),true,MessagesSuccess.UserUpdated);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }
    }
}
