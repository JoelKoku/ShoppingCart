using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models.DTOs;

namespace ShoppingCart.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreRepository _genreRepository;
        private readonly ApplicationDbContext _db;
        public GenreController(IGenreRepository genreRepository, ApplicationDbContext db)
        {
            _genreRepository = genreRepository;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Genre> g1 = await _genreRepository.ListGenres();
            GenreModelDisplay genres = new GenreModelDisplay()
            {
                Genres = g1
            };
            return View(genres);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Add(genre);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                ModelState.AddModelError("", "Enter a good name");
            }
            return View(genre);
        }
    }
}
