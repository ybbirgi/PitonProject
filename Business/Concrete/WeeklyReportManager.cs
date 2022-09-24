using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WeeklyReportManager : IWeeklyReportService
    {
        IWeeklyReportDao weeklyReportDao;

        public WeeklyReportManager(IWeeklyReportDao weeklyReportDao)
        {
            this.weeklyReportDao = weeklyReportDao;
        }
        [ValidationAspect(typeof(WeeklyReportValidator))]
        [SecuredOperation("admin")]
        public IResult Add(WeeklyReport weeklyReport)
        {
            this.weeklyReportDao.add(weeklyReport);
            return new SuccessResult(Messages.GlobalMessages.DATA_ADDED_SUCCESSFULLY);
        }
        [SecuredOperation("admin")]
        public IDataResult<List<WeeklyReport>> getAll()
        {
            return new SuccessDataResult<List<WeeklyReport>>(this.weeklyReportDao.getAll());
        }
        [SecuredOperation("admin")]
        public IDataResult<List<WeeklyReport>> getAllByUserId(int userId)
        {
            return new SuccessDataResult<List<WeeklyReport>>(this.weeklyReportDao.getAll(p => p.userId == userId));
        }
        [SecuredOperation("admin")]
        public IDataResult<WeeklyReport> getById(int reportId)
        {
            return new SuccessDataResult<WeeklyReport>(this.weeklyReportDao.get(p => p.reportId == reportId));
        }
        [SecuredOperation("admin")]
        public IDataResult<List<WeeklyReportDto>> getWeeklyReportDetails()
        {
            return new SuccessDataResult<List<WeeklyReportDto>>(this.weeklyReportDao.GetWeeklyReportDetails());
        }
    }
}
