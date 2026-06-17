using EcommerceMonolith.Models;

namespace EcommerceMonolith.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetById(int id);
    Product Create(Product product);
}
