using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.Entities.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public DateTime? BirthDate { get; set; }
        public string? Adress { get; set; }
    }
}
