using Core.IDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class DetailCar:IDetailCar
    {

        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public Decimal DailyPrice { get; set; }
        public string Desciption { get; set; }
        public string Id { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public DateTime ModelYear { get; set; }



    }
}
