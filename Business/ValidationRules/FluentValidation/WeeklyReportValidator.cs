using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WeeklyReportValidator : AbstractValidator<WeeklyReport>
    {
        public WeeklyReportValidator()
        {
            RuleFor(p => p.reportTopic).MinimumLength(3).MaximumLength(20);
            RuleFor(p => p.reportTopic).NotNull();
            RuleFor(p => p.reportComment).MinimumLength(10).MaximumLength(250);
            RuleFor(p => p.reportComment).NotNull();
            RuleFor(p => p.startDate).NotNull();
            RuleFor(p => p.endDate).NotNull();
        }
    }
}
