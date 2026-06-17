using EcommerceMonolith.Models;
using EcommerceMonolith.Repositories;
using EcommerceMonolith.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepo;
    private readonly IProductRepository _productRepo;

    public OrderService(IOrderRepository orderRepo, IProductRepository productRepo)
    {
        _orderRepo = orderRepo;
        _productRepo = productRepo;
    }

    public void CreateOrder(Order order)
    {
        var products = _productRepo.GetAllProducts().ToList();

        foreach (var item in order.Items)
        {
            var product = products.FirstOrDefault(p => p.Id == item.ProductId);

            if (product == null)
                throw new Exception($"Product {item.ProductId} not found");

            // Set price from product (IMPORTANT)
            item.Price = product.Price;
        }

        _orderRepo.Create(order);
    }

    public IEnumerable<Order> GetUserOrders(int userId)
    {
        return _orderRepo.GetByUserId(userId);
    }
}