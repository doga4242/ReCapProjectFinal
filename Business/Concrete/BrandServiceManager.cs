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
    public class BrandServiceManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandServiceManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int ıd)
        {
            

            return new SuccessDataResult<List<Brand>>(_brandDal.GetByBrandId(ı => ı.BrandId == ıd),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Brand>> GetByCategoryId(int ıd)
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetByCategoryId(ı => ı.BrandId == ıd),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Brand>> GetByColorId(int ıd)
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetByColorId(ı => ı.BrandId == ıd),true,MessagesSuccess.CarsListed);
        }

     

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }
    }
}
