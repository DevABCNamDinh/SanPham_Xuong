using Xuong_C_.Models;

namespace Xuong_C_.Service
{
    public interface ICartService
    {
        void AddToCart(Guid userId, Guid bookId, int quantity);
        List<CartItem> GetCartItems(Guid cartId);
        Cart GetCartFromUserId(Guid userId);
        void UpdateCartItem(Guid cartItemId, int quantity);
        void RemoveCartItem(Guid cartItemId);
        void ClearCart(Guid cartId);
    }
}
