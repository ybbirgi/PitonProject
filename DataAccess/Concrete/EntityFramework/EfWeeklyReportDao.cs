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
    public class EfWeeklyReportDao : EfEntityRepositoryBase<WeeklyReport, ApplicationDbContext>, IWeeklyReportDao
    {
        public List<WeeklyReportDto> GetWeeklyReportDetails()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                var result = from a in context.WeeklyReports
                             join b in context.Users
                             on a.userId equals b.Id
                             select new WeeklyReportDto
                             {
                                 reportId = a.reportId
                             ,
                                 dayReported = a.dayReported
                             ,
                                 reportTopic = a.reportTopic
                             ,
                                 reportComment = a.reportComment
                             ,
                                 startDate = a.startDate
                             ,
                                 endDate = a.endDate
                             ,
                                 userId = a.userId
                             };
                return result.ToList();
            }
        }
    }
}
