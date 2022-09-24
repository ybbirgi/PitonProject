using Business.Abstract;
using Core.Entities.Concretes;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeeklyReportsController : ControllerBase
    {
        IWeeklyReportService weeklyReportService;

        public WeeklyReportsController(IWeeklyReportService weeklyReportService)
        {
            this.weeklyReportService = weeklyReportService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = weeklyReportService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(WeeklyReport weeklyReport)
        {
            var result = weeklyReportService.Add(weeklyReport);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
