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
    public class UserServiceManager : IUserService
    {
        IUserService _userService;

        public UserServiceManager(IUserService userService)
        {
            _userService = userService;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userService.Add(user);



            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userService.Delete(user);

            return new SuccessResult();
        }

        public IDataResult <List<User>> GetAll()
        {
            _userService.GetAll();

            return new SuccessDataResult<List<User>>();
        }

        public IResult Update(User user)
        {
            _userService.Update(user);

            return new SuccessResult();
        }
    }
}
