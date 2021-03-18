using Core.DataAccess.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Eframework
{
   public class DetailRentalDal:EfRepositoryBase<DetailRental,EfDataContext>, IDetailRentalDal
    {
        public List<DetailRental> GetRentedCarDetails()
        {

            using (EfDataContext context = new EfDataContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cu in context.Customers
                             on r.CustomerId equals cu.UserId

                             select new DetailRental
                             {
                                 Id = r.Id,
                                 CustomerId = r.CustomerId,
                                 FirstName = cu.FirstName,
                                 LastName = cu.LastName,
                                 BrandId = c.BrandId,
                                 BrandName = b.BrandName,
                                 CarId = r.CarId,
                                 ColorId = co.ColorId,
                                 ColorName = co.ColorName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate




                             };
                 return result.ToList();
            }



        }

    }
}
