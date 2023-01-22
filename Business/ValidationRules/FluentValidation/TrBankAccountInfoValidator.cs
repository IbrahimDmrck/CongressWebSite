using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TrBankAccountInfoValidator : AbstractValidator<TrBankAccountInfo>
    {
        public TrBankAccountInfoValidator()
        {
            RuleFor(x => x.AccountName).NotEmpty().WithMessage("Bu alanı boş bırakmayın");
            RuleFor(x => x.BankName).NotEmpty().WithMessage("Bu alanı boş bırakmayın");
            RuleFor(x => x.Iban).NotEmpty().WithMessage("Bu alanı boş bırakmayın");
            RuleFor(x => x.Description1).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
        }
    }
}
