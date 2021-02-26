using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {

        }
        public CustomerValidator(IValidator validator)
        {
            RuleFor(p => p.FirstName).NotEmpty().GreaterThanOrEqualTo(2.ToString());
            RuleFor(p => p.Email).NotEmpty().EmailAddress();
            RuleFor(p => p.Password).NotEmpty().GreaterThan((8).ToString());
            RuleFor(p => p.LastName).NotEmpty();

        }

    }
}
