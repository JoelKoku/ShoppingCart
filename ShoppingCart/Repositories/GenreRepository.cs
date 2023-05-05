using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _db;
        public GenreRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool DeleteGenre(Genre genre)
        {
            _db.Genres.Remove(genre);
            return Save();
        }

        public async Task<Genre> GetGenre(int id)
        {
            return await _db.Genres.FirstOrDefaultAsync(i=>i.Id == id);
                
        }

        public async Task<IEnumerable<Genre>> ListGenres()
        {
            return await _db.Genres.ToListAsync();

        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateGenre(Genre genre)
        {
            _db.Genres.Update(genre);
            return Save();
        }
    }
}
