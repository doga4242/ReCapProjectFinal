using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
   public interface ICategoryDal:IEfRepository<Category>
    {
    }
}
