using System.Collections.Generic;

namespace GarageApp.Domain.Entities
{
    public class ProductType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}