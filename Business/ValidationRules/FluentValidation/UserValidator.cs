using Core.Entities.Concretes;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).MinimumLength(3);
            RuleFor(p => p.FirstName).NotNull();
            RuleFor(p => p.LastName).MinimumLength(3);
            RuleFor(p => p.LastName).NotNull();
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Email).NotNull();
        }
    }
}
