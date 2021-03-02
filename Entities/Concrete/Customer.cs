using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:User,ICustomer
    {
        public string CompanyName { get; set; }
        public string UserId { get; set; }

    }
}
