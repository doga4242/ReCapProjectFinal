using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Eframework
{
   public class CustomerDal:EfRepositoryBase<Customer,EfDataContext>
    {
    }
}
