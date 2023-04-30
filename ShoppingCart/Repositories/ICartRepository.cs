namespace ShoppingCart.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int bookId, int qty);
        Task<int> RemoveItem(int bookId);
        Task<ShopingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShopingCart> GetCart(string userId);
        string GetUserId();
        Task<bool> DoCheckout();
    }
}