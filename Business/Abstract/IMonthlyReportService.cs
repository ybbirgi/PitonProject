using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMonthlyReportService
    {
        IDataResult<List<MonthlyReport>> getAll();
        IDataResult<List<MonthlyReport>> getAllByUserId(int userId);
        IDataResult<List<MonthlyReportDto>> getMonthlyReportDetails();
        IDataResult<MonthlyReport> getById(int reportId);
        IResult Add(MonthlyReport monthlyReport);
    }
}
