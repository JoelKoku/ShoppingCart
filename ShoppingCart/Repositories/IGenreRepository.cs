namespace ShoppingCart.Repositories
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> ListGenres();
        Task<Genre> GetGenre(int id);
        bool DeleteGenre(Genre genre);
        bool UpdateGenre(Genre genre);
        bool Save();
    }
}
