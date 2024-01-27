using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjet.EntityLayer.Library.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string District { get; set; }//an area of a country or city
        public string City { get; set; }//an area of a country or city
        public string ImageUrl { get; set; }//an area of a country or city
        public List<CustomerAccount> CustomerAccounts { get; set; }//an area of a country or city



    }
}
