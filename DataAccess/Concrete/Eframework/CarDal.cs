using Core.DataAccess.Concrete;
using Core.IDto;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Eframework
{
   public class CarDal:EfRepositoryBase<Car,EfDataContext>,ICarDal
    {

        public List<DetailCar> GetCarDetails(string Id)
        {

           

            using (EfDataContext context = new EfDataContext())
            {


                var result = from c in context.Cars
                             join k in context.Brands
                             on c.BrandId equals k.BrandId
                             join l in context.Colors
                             on c.ColorId equals l.ColorId



                             select new DetailCar
                             {
                                 BrandId = c.BrandId,
                                 BrandName = k.BrandName,
                                 ColorId = l.ColorId,
                                 ColorName = l.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Desciption = c.Description,
                                 Id = c.Id,
                                 ModelYear = c.ModelYear,
                             };


                return result.ToList();
            }
            
        }


    }
}
