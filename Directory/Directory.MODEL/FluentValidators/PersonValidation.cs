using Directory.MODEL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MODEL.FluentValidators
{
    public class PersonValidation: AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Zorunlu Alan !").MaximumLength(20);
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Zorunlu Alan !").MaximumLength(20);
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Zorunlu Alan !").MaximumLength(11);
            RuleFor(x => x.Company).NotEmpty().WithMessage("Zorunlu Alan !").MaximumLength(20);
        }
    }
}
