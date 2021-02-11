using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UWA.Business.Abstract;
using UWA.Shared;

namespace UWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> SampleCounter()
        {
            if (ModelState.IsValid)
            {
                var result = await _sampleService.SampleCounter();

                return Ok(result);
            }

            return BadRequest();
        }
    }
}
