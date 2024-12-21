using Microsoft.AspNetCore.Mvc;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private static List<State> stateList = new List<State>();

        [HttpGet("GetStatesObsolete")]
        public IActionResult GetStates()
        {
            return Ok(stateList);
        }

        [HttpPost("PostState")]
        public IActionResult PostState([FromBody] State state)
        {
            stateList.Add(state);
            return Ok();
        }

        // Docs

        [HttpGet("GetHome")]
        public IActionResult GetText()
        {
            var result = "Return in text";
            return Content(result);
            //return Ok();
            //return Ok(result);
            //return BadRequest();
            //return BadRequest(result);
        }

        [HttpGet("GetSecondHome")]
        public IActionResult GetSecondText()
        {
            var result = "Return in second text";
            return Content(result);
        }

        //[HttpGet("GetThirdHome/{value}")]
        //public IActionResult GetThirdText(string value)
        //{
        //    var result = $"Return in third text {value}";
        //    return Content(result);
        //}

        [HttpGet("GetThirdHome/{value}")]
        public IActionResult GetThirdText([FromRoute] string value)
        {
            var result = $"Return in third text {value}";
            return Content(result);
        }

        [HttpGet("GetFourthHome/{value}")]
        public IActionResult GetFourthText([FromQuery] string value)
        {
            var result = $"Return in fourth text {value}";
            return Content(result);
        }

        [HttpPost("/{value}")]
        public IActionResult PostText([FromRoute] string value)
        {
            var result = $"Post text {value}";
            return Content(result);
        }
    }
}
