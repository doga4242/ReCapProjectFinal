using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductValidator:AbstractValidator<Car>
    {
        public ProductValidator()
        {
        }

        public ProductValidator(IValidator validator)
        {
            RuleFor(p => p.Description).NotEmpty().MinimumLength(2);
            RuleFor(p => p.Id).NotEmpty().GreaterThan((0));
            RuleFor(p => p.CategoryId).NotEmpty().NotEqual(p => p.CategoryId);
            RuleFor(p => p.DailyPrice).NotEmpty().GreaterThan(10);

        }

    }
}
