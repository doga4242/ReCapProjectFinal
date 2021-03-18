using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:User
    {
        public string CompanyName { get; set; }
        public int UserId { get; set; }
        
    }
}
