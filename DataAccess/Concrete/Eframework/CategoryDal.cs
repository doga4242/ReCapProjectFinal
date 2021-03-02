using Core.DataAccess.Concrete;
using DataAccess.Abstract.IEframework;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Eframework
{
   public class CategoryDal: EfRepositoryBase<Category,EfDataContext>,ICategoryDal
    {
    }
}
