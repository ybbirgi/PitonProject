using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WeeklyReport : Report
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
