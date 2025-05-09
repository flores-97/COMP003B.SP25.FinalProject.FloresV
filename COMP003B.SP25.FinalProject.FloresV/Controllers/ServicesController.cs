using COMP003B.SP25.FinalProject.FloresV.Data;
using COMP003B.SP25.FinalProject.FloresV.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.FinalProject.FloresV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesApiController : Controller
    {
        [HttpGet]
        public ActionResult<List<Service>> GetServices()
        {
            return Ok(ServiceData.Services);
        }

        [HttpGet("{id}")]
        public ActionResult<Service> GetServices(int id)
        {
            var service = ServiceData.Services.FirstOrDefault(s => s.ServiceId == id);
            if(service is null)
                return NotFound();
            return Ok(service);
        }
        [HttpPost]
        public ActionResult<Service> CreateService (Service service)
        {
            service.ServiceId = ServiceData.Services.Max(s => s.ServiceId) + 1;
            ServiceData.Services.Add(service);
            return CreatedAtAction(nameof(GetServices), new { id = service.ServiceId }, service);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateService(int id, Service updateService)
        {
            var existingService = ServiceData.Services.FirstOrDefault(s =>s.ServiceId == id);
            if (existingService is null)
                return NotFound();
            existingService.ServiceBranch = updateService.ServiceBranch;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var service = ServiceData.Services.FirstOrDefault(s =>s.ServiceId == id); 
            if (service is null) 
                return NotFound();
            ServiceData.Services.Remove(service);
            return NoContent();
        }

        [HttpGet("filter")]
        public ActionResult<List<Service>> FilterService(string serviceBranch)
        {
            var filterBranch = ServiceData.Services
                .Where(s => s.ServiceBranch == serviceBranch)
                .OrderBy(s => s.ServiceId)
                .ToList();
            return Ok(filterBranch);
        }
        [HttpGet("names")]
        public ActionResult<List<string>> GetServiceBranch()
        {
            var serviceBranch = ServiceData.Services
                .OrderBy(s => s.ServiceBranch)
                .Select(s => s.ServiceBranch)
                .ToList();
            return Ok(serviceBranch);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
