using DemoProject.WebApi.Dtos.ProductDto;
using DemoProject.WebApi.Services.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.WebApi.Controllers
{
    //[Authorize]
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase, IProductService
    {
        private IProductService _productService;

        public ProductController(
            IProductService productService
        )
        {
            _productService = productService;
        }

        [HttpPost] // api/product
        public async Task<ProductDto> Create(ProductDto product)
        {
            return await _productService.Create(product);
        }

        [HttpDelete("{id}")] //api/product/{id}
        public Task<object> Delete(string id)
        {
            return _productService.Delete(id);
        }

        [HttpGet("{id}")] //api/product/{id}
        public async Task<ProductDto> GetProduct(string id)
        {
            return await _productService.GetProduct(id);
        }

        [HttpGet] //api/product
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _productService.GetProducts();
        }

        [HttpPut("{id}")] //api/product/{id}
        public async Task<ProductDto> Update(ProductDto product)
        {
            return await _productService.Update(product);
        }
    }
}
