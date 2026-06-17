using EcommerceMonolith.Models;

namespace EcommerceMonolith.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m },
        new Product { Id = 2, Name = "Smartphone", Price = 499.99m },
        new Product { Id = 3, Name = "Headphones", Price = 89.99m }
    };

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public Product Create(Product product)
    {
        // Simulate auto-increment ID
        product.Id = _products.Max(p => p.Id) + 1;

        _products.Add(product);

        return product;
    }
}