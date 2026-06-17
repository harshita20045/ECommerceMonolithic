using EcommerceMonolith.Models;
using EcommerceMonolith.Repositories;

namespace EcommerceMonolith.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Product> GetAll()
    {
        return _repository.GetAllProducts();
    }

    public Product GetById(int id)
    {
        var product = _repository.GetById(id);

        if (product == null)
            throw new Exception("Product not found");

        return product;
    }

    public Product Create(Product product)
    {
      

        if (string.IsNullOrWhiteSpace(product.Name))
            throw new Exception("Product name is required");

        if (product.Price <= 0)
            throw new Exception("Price must be greater than zero");

   
        return _repository.Create(product);
    }
}