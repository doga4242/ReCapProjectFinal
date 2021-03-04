using Core.Entity;
using Core.IDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class DetailRental:IRentalCarDTO
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public string BrandName { get; set; }
        public DateTime ModelYear { get; set; }
        public int BrandId { get; set; }


    }
}
