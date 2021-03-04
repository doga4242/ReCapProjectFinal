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
    public class UserServiceManager : IUserService
    {
        IUserDal _userDal;

        public UserServiceManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IDataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userDal.GetById(i => i.Id == Id), true, MessagesSuccess.UserUpdated);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }
    }
}
