namespace ShoppingCart.Repositories
{
    public interface IHomeRepsoitory
    {
        Task<IEnumerable<Book>> GetBooks(string sTerm="",int genreId=0);
        Task<IEnumerable<Genre>> GetGenres();
    }
}