using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjet.DtoLayer.Library.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage = "Name is required")]
        //[Display(Name ="Isim:")]
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassWord { get; set; }
    }
}
