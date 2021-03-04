﻿using Core.Entity;
using Core.IDto;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Rental:IRental
    {

        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CustomerId { get; set; }
        

    }
}
