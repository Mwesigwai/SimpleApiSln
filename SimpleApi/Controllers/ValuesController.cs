using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var testResult = new List<string>
            {
                "Isaac",
                "Mwesigwa"
            };
            return Ok(testResult);
        }


        [HttpGet("{id : int}")]
        public ActionResult<string> Get(int id)
        {
            //for test purposes is redundant
            return "Isaac Mwesigwa";
        }
    }
}
