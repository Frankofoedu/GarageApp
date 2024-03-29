﻿using System;

namespace GarageApp.Domain.Entities
{
    public class Cart
    {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public DateTime DatePurchased { get; set; }
        public bool IsInCart { get; set; }

        public virtual Product Product { get; set; }
    }
}