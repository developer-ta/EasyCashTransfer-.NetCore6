using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjet.EntityLayer.Library.Concrete
{
    public class CustomerAccountProcesse
    {
        public int CustomerAccountProcesseID { get; set; }
        public string ProcesseType { get; set; }
        public decimal Amount { get; set; }//montante
        public DateTime ProcesseDate { get; set; }//montante

    }
}
