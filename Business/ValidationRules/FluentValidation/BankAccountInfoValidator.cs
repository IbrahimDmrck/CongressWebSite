using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BankAccountInfoValidator:AbstractValidator<BankAccountInfo>
    {
        public BankAccountInfoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MinimumLength(50).MaximumLength(500).WithMessage("Bu alanı boş bırakmayın | 50 - 500 karakter olmalı");
            RuleFor(x => x.Country).NotEmpty().NotEmpty().MinimumLength(2).MaximumLength(50).WithMessage("Bu alanı boş bırakmayın | 2 - 50 karakter olamlı");
            RuleFor(x => x.Branch).NotEmpty().NotEmpty().MinimumLength(10).MaximumLength(100).WithMessage("Bu alanı boş bırakmayın | 10 - 100 karakter olamlı");
            RuleFor(x => x.BankCode).NotEmpty().NotEmpty().MinimumLength(5).MaximumLength(50).WithMessage("Bu alanı boş bırakmayın | 5 - 50 karakter olmalı");
            RuleFor(x => x.Address).NotEmpty().NotEmpty().MinimumLength(10).MaximumLength(500).WithMessage("Bu alanı boş bırakmayın | 10 - 500 karakter olamalı");
            RuleFor(x => x.AccountNumber).NotEmpty().NotEmpty().MinimumLength(5).MaximumLength(50).WithMessage("Bu alanı boş bırakmayın | 5 - 50 karakter olmalı");
        }

    }
}
