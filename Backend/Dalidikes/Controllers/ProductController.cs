using Dalidikes.Interfaces;
using Dalidikes.RequestModels;
using Dalidikes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Dalidikes.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductVm>> GetAllProductsAsync([FromHeader] PageLimit pageLimit)
        {
            var list = (await _productRepository.GetAllAsync(pageLimit));
            return list;
        }
    }
}