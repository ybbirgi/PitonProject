using Core.Entities;
using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Report : IEntity
    {
        [Key]
        public int reportId { get; set; }
        public DateTime dayReported { get; set; }
        public string reportTopic { get; set; }
        public string reportComment { get; set; }
        public int userId { get; set; }
    }
}
