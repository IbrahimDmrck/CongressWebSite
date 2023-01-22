using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class GeneralInformationValidator : AbstractValidator<GeneralInformation>
    {
        public GeneralInformationValidator()
        {
            RuleFor(x => x.PaperEvaluation).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
            RuleFor(x => x.SummaryContent).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
            RuleFor(x => x.Rules).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
        }
    }
}
