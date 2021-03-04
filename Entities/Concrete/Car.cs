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

        public int Id { get; set; }
        public int BrandId { get; set; }

        public long ColorId  { get; set; }
        public DateTime ModelYear { get; set; }

        public int CategoryId { get; set; }





    }
}
