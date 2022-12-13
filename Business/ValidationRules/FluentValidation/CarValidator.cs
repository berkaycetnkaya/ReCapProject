using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {

        public CarValidator()
        {
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(100);
            RuleFor(p => p.ModelYear).GreaterThanOrEqualTo(2022).When(p => p.BrandId == 5);
        }
        // withmessage ekleyebilirsin
    }
}
