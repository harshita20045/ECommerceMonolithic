using EcommerceMonolith.Models;

namespace EcommerceMonolith.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    Product Create(Product product);



}
