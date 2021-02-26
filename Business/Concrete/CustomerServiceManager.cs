using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerServiceManager : ICustomerService
    {
        ICustomerService _customerService;

        public CustomerServiceManager(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerService.Add(customer);

            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerService.Delete(customer);

            return new SuccessResult();
        }

        public IResult Update(Customer customer)
        {
            _customerService.Update(customer);

            return new SuccessResult();
        }
    }
}
