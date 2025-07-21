using MicroProvisioning.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroProvisioning.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvisioningController(IServices _services) : Controller
    {
        [HttpPost(Name = "Provisioning")]
        public IActionResult Provisioning()
        {
            return Ok();
        }
    }
}
