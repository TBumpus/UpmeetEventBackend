using Microsoft.AspNetCore.Mvc;
using UpmeetEventBackend.Data;
using UpmeetEventBackend.Models;

namespace UpmeetEventBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        EventDb Db = new EventDb();

        [HttpGet("GetAllEvents")]
        public IActionResult GetAllEvents()
        {
            return Ok();
        }

        [HttpGet("GetEventById")]
        public IActionResult GetEventById()
        {
            return Ok();
        }

        [HttpPost("AddEventToFavorites")]
        public IActionResult AddEventToFavorites()
        {
            return Ok();
        }

        [HttpGet("GetAllFavorites")]
        public IActionResult GetAllFavorites()
        {
            return Ok();
        }

        [HttpDelete("RemoveFromFavorites")]
        public IActionResult RemoveFromFavorites()
        {
            return Ok();
        }

        [HttpPost("AddEvent")]
        public IActionResult AddEvent()
        {
            return Ok();
        }
    }
}
