using GrantTest.Data.Repositories;
using GrantTest.Domain.Commands.Requests;
using GrantTest.Domain.Commands.Responses;
using GrantTest.Models;
using GrantTest.Service;
using MediatR;

namespace GrantTest.Domain.Commands.Handlers
{
  public class ProductHandler : IRequestHandler<ProductRequest, ProductResponse>
    {          
        private readonly IProductRepository _productRepository;

        public ProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<ProductResponse> Handle(ProductRequest request, CancellationToken cancellationToken)
        {
            var products = _productRepository.GetProducts();
            var result = new ProductResponse{ Products = products };
            return Task.FromResult(result);
        }
    }

}