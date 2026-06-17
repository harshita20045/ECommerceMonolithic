using EcommerceMonolith.Models;

namespace EcommerceMonolith.Services
{
    public interface IOrderService
    {
        void CreateOrder(Order request);
        IEnumerable<Order> GetUserOrders(int userId);
    }
}
