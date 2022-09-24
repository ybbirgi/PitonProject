using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MonthlyReportManager : IMonthlyReportService
    {
        EfMonthlyReportDao monthlyReportDao;

        public MonthlyReportManager(EfMonthlyReportDao monthlyReportDao)
        {
            this.monthlyReportDao = monthlyReportDao;
        }
        [ValidationAspect(typeof(MonthlyReportValidator))]
        [SecuredOperation("admin")]
        public IResult Add(MonthlyReport monthlyReport)
        {
            this.monthlyReportDao.add(monthlyReport);
            return new SuccessResult(Messages.GlobalMessages.DATA_ADDED_SUCCESSFULLY);
        }
        [SecuredOperation("admin")]
        public IDataResult<List<MonthlyReport>> getAll()
        {
            return new SuccessDataResult<List<MonthlyReport>>(this.monthlyReportDao.getAll());
        }
        [SecuredOperation("admin")]
        public IDataResult<List<MonthlyReport>> getAllByUserId(int userId)
        {
            return new SuccessDataResult<List<MonthlyReport>>(this.monthlyReportDao.getAll(p => p.userId == userId));
        }
        [SecuredOperation("admin")]
        public IDataResult<MonthlyReport> getById(int reportId)
        {
            return new SuccessDataResult<MonthlyReport>(this.monthlyReportDao.get(p => p.reportId == reportId));
        }
        [SecuredOperation("admin")]
        public IDataResult<List<MonthlyReportDto>> getMonthlyReportDetails()
        {
            return new SuccessDataResult<List<MonthlyReportDto>>(this.monthlyReportDao.GetMonthlyReportDetails());
        }
    }
}
