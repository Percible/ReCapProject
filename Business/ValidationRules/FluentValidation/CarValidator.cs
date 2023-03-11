using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {

        public CarValidator()
        {
            RuleFor(c=>c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(20);
            RuleFor(c => c.Description).MinimumLength(2);

        }


    }
}
