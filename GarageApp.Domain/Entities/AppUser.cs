﻿namespace GarageApp.Domain.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
    }
}