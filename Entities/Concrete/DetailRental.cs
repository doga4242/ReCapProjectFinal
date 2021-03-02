using Core.Entity;
using Core.IDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class DetailRental:IRentalCarDTO
    {
        public string Id { get; set; }
        public string CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CustomerId { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public string ColorId { get; set; }
        public string BrandName { get; set; }
        public DateTime ModelYear { get; set; }
        public string BrandId { get; set; }


    }
}
