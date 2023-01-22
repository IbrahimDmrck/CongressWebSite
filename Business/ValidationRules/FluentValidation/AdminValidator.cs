using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
           
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalı"); ;
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta alanı boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir e-posta adresi giriniz");
        }
    }
}
