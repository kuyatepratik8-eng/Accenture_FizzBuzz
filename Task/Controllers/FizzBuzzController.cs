using Microsoft.AspNetCore.Mvc;
using Task.Interface;
using Task.Model;

namespace Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<List<FizzBuzzResult>> ProcessArray([FromBody] string[] values)
        {
            if (values == null || values.Length == 0)
                return BadRequest("Input array cannot be empty.");

            var results = values.Select(v => _service.ProcessValue(v)).ToList();
            return Ok(results);
        }
    }
}
