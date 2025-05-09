using COMP003B.SP25.FinalProject.FloresV.Data;
using COMP003B.SP25.FinalProject.FloresV.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.FinalProject.FloresV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesApi : Controller
    {
        [HttpGet]
        public ActionResult<List<Services>> GetServices()
        {
            return Ok(ServicesData.Services);
        }

        [HttpGet("{id}")]
        public ActionResult<Services> GetServices(int id)
        {
            var services = ServicesData.Services.FirstOrDefault(b => b.ServiceId == id);

            if (services is null)
                return NotFound();

            return Ok(services);
        }

        [HttpPost]
        public ActionResult<Services> CreateServices(Services services)
        {
            services.ServiceId = ServicesData.Services.Max(b => b.ServiceId) + 1;
            ServicesData.Services.Add(services);
            return CreatedAtAction(nameof(GetServices), new { id = services.ServiceId }, services);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateServices(int id, Services updateServices)
        {
            var existingService = ServicesData.Services.FirstOrDefault(b => b.ServiceId == id);

            if (existingService is null)
                return NotFound();

            existingService.ServiceBranch = updateServices.ServiceBranch;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var services = ServicesData.Services.FirstOrDefault(b => b.ServiceId == id);

            if (services is null)
                return NotFound();

            ServicesData.Services.Remove(services);

            return NoContent();
        }

        [HttpGet("names")]
        public ActionResult<List<string>> GetServiceNames()
        {
            var servicesName = ServicesData.Services
                .OrderBy(b => b.ServiceBranch)
                .Select(b => b.ServiceBranch)
                .ToList();

            return Ok(servicesName);
        }
    }
}