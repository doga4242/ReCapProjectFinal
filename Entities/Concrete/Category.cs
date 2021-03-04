using Core.Entity;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category:ICategory
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
