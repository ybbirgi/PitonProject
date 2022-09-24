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
    public interface IDailyReportService
    {
        IDataResult<List<DailyReport>> getAll();
        IDataResult<List<DailyReport>> getAllByUserId(int userId);

        IDataResult<List<DailyReportDto>> getDailyReportDetails();
        IDataResult<DailyReport> getById(int reportId);

        IResult Add(DailyReport dailyReport);
    }
}
