using Core.DataAccess.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Eframework
{
    public class RentalDal : EfRepositoryBase<Rental, EfDataContext>, IRentalDal
    {
       public List<DetailRental> GetRentedCarDetails()
        {

            using(EfDataContext context=new EfDataContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             join u in context.Customers
                             on r.CustomerId equals u.UserId
                             join y in context.Colors
                             on c.ColorId equals y.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId




                             select new DetailRental
                             {
                                 CarId = c.Id,
                                 CustomerId = u.UserId,
                                 Id = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 BrandId = c.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = y.ColorId,
                                 ColorName = y.ColorName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear


                             };
                return result.ToList();
            }

        }


    }
}
