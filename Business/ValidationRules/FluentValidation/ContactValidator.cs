using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage(" En az 2 karakter girin");
            RuleFor(x => x.NameSurname).MaximumLength(100).WithMessage("En Fazla 100 karakter girin");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli bir email giriniz ");

            RuleFor(x => x.Message).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.Message).MinimumLength(2).WithMessage(" En az 2 karakter girin");
            RuleFor(x => x.Message).MaximumLength(200).WithMessage("En Fazla 200 karakter girin");

        }
    }
}
