using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.Entities.Entities
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        //Mapping
        public virtual List<Product> products { get; set; }
    }
}
