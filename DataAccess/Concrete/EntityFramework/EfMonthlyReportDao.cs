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
    public class EfMonthlyReportDao : EfEntityRepositoryBase<MonthlyReport, ApplicationDbContext>, IMonthlyReportDao

    {
        public List<MonthlyReportDto> GetMonthlyReportDetails()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var result = from a in context.MonthlyReports
                             join b in context.Users
                             on a.userId equals b.Id
                             select new MonthlyReportDto
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
                                 dateMonth = a.dateMonth
                             };
                return result.ToList();
            }
        }
    }
}
