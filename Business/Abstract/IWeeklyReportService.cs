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
    public interface IWeeklyReportService
    {
        IDataResult<List<WeeklyReport>> getAll();
        IDataResult<List<WeeklyReport>> getAllByUserId(int userId);
        IDataResult<List<WeeklyReportDto>> getWeeklyReportDetails();
        IDataResult<WeeklyReport> getById(int reportId);
        IResult Add(WeeklyReport weeklyReport);

    }
}
