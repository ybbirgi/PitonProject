using Business.Abstract;
using Core.Entities.Concretes;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyReportsController : ControllerBase
    {
        IDailyReportService dailyReportService;

        public DailyReportsController(IDailyReportService dailyReportService)
        {
            this.dailyReportService = dailyReportService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = dailyReportService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(DailyReport dailyReport)
        {
            var result = dailyReportService.Add(dailyReport);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
