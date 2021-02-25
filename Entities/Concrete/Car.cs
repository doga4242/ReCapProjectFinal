using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car:ICar
    {
        public string Description { get; set; }
        public Decimal DailyPrice { get; set; }

        public string Id { get; set; }
        public string BrandId { get; set; }

        public string ColorId  { get; set; }
        public DateTime ModelYear { get; set; }

        public string CategoryId { get; set; }





    }
}
