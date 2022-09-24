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
    public class DailyReportManager : IDailyReportService
    {
        EfDailyReportDao dailyReportDao;

        public DailyReportManager(EfDailyReportDao dailyReportDao)
        {
            this.dailyReportDao = dailyReportDao;
        }

        [ValidationAspect(typeof(DailyReportValidator))]
        [SecuredOperation("admin")]
        public IResult Add(DailyReport dailyReport)
        {
            this.dailyReportDao.add(dailyReport);
            return new SuccessResult(Messages.GlobalMessages.DATA_ADDED_SUCCESSFULLY);
        }
        [SecuredOperation("admin")]
        public IDataResult<List<DailyReport>> getAll()
        {
            return new SuccessDataResult<List<DailyReport>>(this.dailyReportDao.getAll());
        }
        [SecuredOperation("admin")]
        public IDataResult<List<DailyReport>> getAllByUserId(int userId)
        {
            return new SuccessDataResult<List<DailyReport>>(this.dailyReportDao.getAll(p => p.userId == userId));
        }
        [SecuredOperation("admin")]
        public IDataResult<DailyReport> getById(int reportId)
        {
            return new SuccessDataResult<DailyReport>(this.dailyReportDao.get(p => p.reportId == reportId));
        }
        [SecuredOperation("admin")]
        public IDataResult<List<DailyReportDto>> getDailyReportDetails()
        {
            return new SuccessDataResult<List<DailyReportDto>>(this.dailyReportDao.GetDailyReportDetails());
        }
    }
}
