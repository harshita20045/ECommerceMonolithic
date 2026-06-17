using EcommerceMonolith.Models;

namespace EcommerceMonolith.Repositories
{
    public interface IOrderRepository
    {
        void Create(Order order);
        IEnumerable<Order> GetByUserId(int userId);
    }
}
