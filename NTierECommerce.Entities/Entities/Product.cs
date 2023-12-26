using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.Entities.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string? ImagePath { get; set; }
        //public List<string> ImagePaths { get; set; }

        //Mapping
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
