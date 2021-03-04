using Business.Abstract;
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
    public class CategoryServiceManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryServiceManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            

            return new SuccessDataResult<List<Category>>(_categoryDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Category>> GetByCategoryId(int id)
        {
            

            return new SuccessDataResult<List<Category>>(_categoryDal.GetByCategoryId(i => i.CategoryId == id),true,MessagesSuccess.CarsListed);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);

            return new SuccessDataResult<List<Category>>(MessagesSuccess.CarsUpdated);
        }
    }
}
