using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DailyReportDto:IDto
    {
        public int reportId { get; set; }
        public DateTime dayReported { get; set; }
        public string reportTopic { get; set; }
        public string reportComment { get; set; }
        public int userId { get; set; }
        public string reportDay { get; set; }
    }
}
