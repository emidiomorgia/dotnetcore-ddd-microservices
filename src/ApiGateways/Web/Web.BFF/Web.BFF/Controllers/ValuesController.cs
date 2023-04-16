using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace Web.BFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private IEnumerable<ValueItem> _items = new List<ValueItem>() { new ValueItem(1,"a"), new ValueItem(2,"b"), new ValueItem(3,"c") };

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ValueItem))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {

            var item = _items.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                return Ok(item);
            }
            else
            {
                return NotFound();
            }

        }
    }
}