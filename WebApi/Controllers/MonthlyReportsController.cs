using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthlyReportsController : ControllerBase
    {
        IMonthlyReportService monthlyReportService;

        public MonthlyReportsController(IMonthlyReportService monthlyReportService)
        {
            this.monthlyReportService = monthlyReportService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = monthlyReportService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(MonthlyReport monthlyReport)
        {
            var result = monthlyReportService.Add(monthlyReport);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
