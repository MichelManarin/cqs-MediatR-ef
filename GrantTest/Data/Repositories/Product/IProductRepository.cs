using GrantTest.Models;

namespace GrantTest.Data.Repositories
{
  public interface IProductRepository
  {
    public IEnumerable<Product>? GetProducts();

  } 
}