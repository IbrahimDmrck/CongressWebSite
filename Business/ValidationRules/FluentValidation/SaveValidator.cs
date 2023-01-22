using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public  class SaveValidator:AbstractValidator<Save>
    {
        public SaveValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
            RuleFor(x => x.VideoConferenceDescription).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
            RuleFor(x => x.ParticipationPriceServiceAdditionDescription).NotEmpty().MinimumLength(50).WithMessage("Bu alanı boş bırakmayın | En az 50 karakter girin");
            RuleFor(x => x.OralPresentationMemberPrice).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.OralPresentationNonMemberPrice).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.VideoConferenceMemberPrice).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
            RuleFor(x => x.VideoConferenceNonMemberPrice).NotEmpty().WithMessage("Bu alanı boş bırakmayın ");
        }
    }
}
