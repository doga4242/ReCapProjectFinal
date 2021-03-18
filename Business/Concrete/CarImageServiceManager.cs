using Business.Abstract;
using Core.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Core.Utilities.Helpers;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageServiceManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageServiceManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = _carImageDal.Getall(i => i.CarId == carImage.CarId);
            if (result.Count > 5)
            {
                return new ErrorResult(MessagesError.CarEntryError);
            }
            else
            {
                carImage.ImagePath = FileHelper.Add(file);
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);

                return new SuccessResult(MessagesSuccess.CarsAdded);

            }

        }

        public IResult Delete(IFormFile file, CarImage carImage)
        {
           
            _carImageDal.Delete(carImage);

            return new SuccessResult(MessagesSuccess.CarsDeleted);
        }

        public IDataResult<List<CarImage>> Get()
        {


            return new SuccessDataResult<List<CarImage>>(_carImageDal.Getall(), true, MessagesSuccess.CarsListed);
        }

        public IDataResult<CarImage> GetCarImageByCarId(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(i => i.CarId == id), true, MessagesSuccess.CarsListed);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            _carImageDal.Update(carImage);

            return new SuccessResult(MessagesSuccess.CarsUpdated);
        }

        private IDataResult<List<CarImage>> CheckIfCarImageNull(int id)
        {
            try
            {
                string path = @"\wwwroot\css\uploads\logo.jpg";
                var result = _carImageDal.Getall(c => c.CarId == id).Any();
                if (!result)
                {
                    List<CarImage> carimage = new List<CarImage>();
                    carimage.Add(new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<CarImage>>(carimage);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<CarImage>>(exception.Message);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.Getall(p => p.CarId == id).ToList());
        }
    }
}
