using GrantTest.Models;

namespace GrantTest.Domain.Commands.Responses
{

  public class ProductResponse
  {
     public IEnumerable<Product>? Products { get; set; }
  }
}