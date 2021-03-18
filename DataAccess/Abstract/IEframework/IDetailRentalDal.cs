using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.IEframework
{
   public interface IDetailRentalDal:IEfRepository<DetailRental>
    {
        List<DetailRental> GetRentedCarDetails();
    }
}
