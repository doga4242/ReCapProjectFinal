using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class RentedCarValidator:AbstractValidator<RentedCar>
    {
        public RentedCarValidator()
        {

        }
        public RentedCarValidator(IValidator validator)
        {
            RuleFor(p => p.RentDate).NotNull();


        }
    }
}
