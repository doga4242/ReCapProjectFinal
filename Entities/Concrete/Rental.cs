using Core.Entity;
using Core.IDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Rental:IEntity,IRentalCarDTO
    {

        public string Id { get; set; }
        public string CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CustomerId { get; set; }
        

    }
}
