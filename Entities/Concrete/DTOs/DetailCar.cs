using Core.IDto;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class DetailCar:ICar
    {

        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public Decimal DailyPrice { get; set; }
        public string Desciption { get; set; }
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime ModelYear { get; set; }



    }
}
