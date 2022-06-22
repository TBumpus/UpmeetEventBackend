using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UpmeetEventBackend.Data;
using UpmeetEventBackend.Models;

namespace UpmeetEventBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllEvents")]
        public IActionResult GetAllEvents()
        {
            if (_context.Events == null)
            {
                return NotFound();
            }

            var response = _context.Events.ToList();

            return Ok(response);
            
        }

        [HttpGet("GetEventById")]
       
        public IActionResult GetEventById(int Id)
        {
            var eventID = _context.Events.Where(x => x.EventId == Id).ToList();
            if (eventID == null)
            {
                return NotFound();
            }
            return Ok(eventID);
        }

        [HttpPost("AddEventToFavorites")]
        public IActionResult AddEventToFavorites(Favorite favorite)
        {         
            _context.Favorites.Add(favorite);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("GetAllFavorites")]
        public IActionResult GetAllFavorites()
        {
            if (_context.Favorites == null)
            {
                return NotFound();
            }

            var response = _context.Favorites.ToList();

            return Ok(response);

        }

        [HttpDelete("RemoveFromFavorites")]
        public IActionResult RemoveFromFavorites(Favorite favorite)
        {
             _context.Favorites.Remove(favorite);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("AddEvent")]
        public IActionResult AddEvent()
        {
            return Ok();
        }
    }
}
