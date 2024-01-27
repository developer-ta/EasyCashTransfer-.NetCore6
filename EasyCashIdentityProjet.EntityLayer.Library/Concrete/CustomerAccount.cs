using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjet.EntityLayer.Library.Concrete
{
    //clients
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; }//devise
        public decimal CustomerAccountBalance { get; set; }//équilibre
        public string BankBranch { get; set; }//équilibre
        public AppUser AppUser { get; set; }//an area of a country or city
        public int AppUserID { get; set; }
    }
}
