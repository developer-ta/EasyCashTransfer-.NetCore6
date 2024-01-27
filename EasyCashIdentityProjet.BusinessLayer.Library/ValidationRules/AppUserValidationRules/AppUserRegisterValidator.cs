using EasyCashIdentityProjet.DtoLayer.Library.Dtos.AppUserDtos;

using FluentValidation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjet.BusinessLayer.Library.ValidationRules.AppUserValidationRules
{//登记
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().
        }
    }
}
