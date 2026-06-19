using EcommerceMonolith.Models;
using EcommerceMonolith.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new();

    public void Create(Order order)
    {
        order.Id = _orders.Count > 0 ? _orders.Max(o => o.Id) + 1 : 1;
        _orders.Add(order);
    }
//by is
    public IEnumerable<Order> GetByUserId(int userId)
    {
        return _orders.Where(o => o.UserId == userId);
    }
}