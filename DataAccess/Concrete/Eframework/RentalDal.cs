using Core.DataAccess.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Eframework
{
    public class RentalDal : EfRepositoryBase<RentedCar, EfDataContext>, IRentalDal
    {
       public List<RentedCarDetails> GetRentedCarDetails()
        {

            using(EfDataContext context=new EfDataContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             from l in context.Users
                             join u in context.Customers
                             on l.Id equals u.UserId

                             select new RentedCarDetails
                             {
                                 CarId = c.Id,
                                 Id = r.Id,
                                 CustomerId = u.UserId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                                 


                             };

                return result.ToList();
            }

        }


    }
}
