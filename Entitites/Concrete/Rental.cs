﻿using Core.Entities;

namespace Entitites.Concrete
{
    public class Rental:IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime RentDate { get; set;}
        public DateTime ReturnDate { get; set; }
    }
}
