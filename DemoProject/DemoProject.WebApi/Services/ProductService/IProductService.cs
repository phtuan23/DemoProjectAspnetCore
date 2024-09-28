using DemoProject.WebApi.Dtos.ProductDto;

namespace DemoProject.WebApi.Services.ProductService
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetProducts();
        public Task<ProductDto> GetProduct(string id);
        public Task<ProductDto> Create(ProductDto product);
        public Task<ProductDto> Update(ProductDto product);
        public Task<object> Delete(string id);
    }
}
