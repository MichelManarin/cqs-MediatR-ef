using GrantTest.Models;

namespace GrantTest.Data.Repositories
{
  public class ProductRepository: IProductRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public ProductRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

        public IEnumerable<Product>? GetProducts()
        {
           return _dbContext.Products.ToList();
        }
    } 
}