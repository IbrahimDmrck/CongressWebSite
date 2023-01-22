using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminContactInfoValidator:AbstractValidator<AdminContactInfo>
    {
        public AdminContactInfoValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Geçerli bir adres giriniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Geçerli bir email giriniz");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Geçerli bir telefon numarası giriniz");
        }
    }
}
