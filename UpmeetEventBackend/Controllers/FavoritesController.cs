using Microsoft.AspNetCore.Mvc;
using UpmeetEventBackend.Data;
using UpmeetEventBackend.Models;

namespace UpmeetEventBackend.Controllers
{
    public class FavoritesController : Controller
    {
        private ApplicationDbContext _context;

        public FavoritesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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
    }
}
