using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class WeeklyReportDto : IDto
    {
        public int reportId { get; set; }
        public DateTime dayReported { get; set; }
        public string reportTopic { get; set; }
        public string reportComment { get; set; }
        public int userId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
