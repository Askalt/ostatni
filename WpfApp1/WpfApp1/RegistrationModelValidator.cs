using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class RegistrationModelValidator : AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidator()
        {
            RuleFor(x => x.login)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .Must(x=>x.Contains)
        }
    }
}
