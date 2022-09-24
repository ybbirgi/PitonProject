using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDailyReportDao : EfEntityRepositoryBase<DailyReport, ApplicationDbContext>, IDailyReportDao
    {
        public List<DailyReportDto> GetDailyReportDetails()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var result = from a in context.DailyReports
                             join b in context.Users
                             on a.userId equals b.Id
                             select new DailyReportDto
                             {
                                 reportId = a.reportId
                             ,
                                 dayReported = a.dayReported
                             ,
                                 reportTopic = a.reportTopic
                             ,
                                 reportComment = a.reportComment
                             ,
                                 userId = a.userId
                             ,
                                 reportDay = a.reportDay
                             };
                return result.ToList();
            }
        }
    }
}
