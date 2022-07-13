using Entitites.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
        }
    }
}
