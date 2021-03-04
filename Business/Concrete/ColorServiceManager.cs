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
    public class ColorServiceManager : IColorService
    {

        IColorDal _colorDal;

        public ColorServiceManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);

            return new SuccessResult(MessagesSuccess.CarsAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            

            return new SuccessDataResult<List<Color>>(_colorDal.Getall(),true,MessagesSuccess.CarsListed);
        }

        public IDataResult<List<Color>> GetByColorId(int id)
        {
            

            return new SuccessDataResult<List<Color>>(_colorDal.GetByCategoryId(i => i.ColorId == id),true,MessagesSuccess.CarsListed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
                
        }
    }
}
