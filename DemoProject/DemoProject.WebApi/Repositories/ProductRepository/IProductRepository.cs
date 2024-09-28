using DemoProject.WebApi.Models;

namespace DemoProject.WebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProduct(string id);
        public Task<Product> Create(Product product);
        public Task<Product> Update(Product product);
        public Task<object> Delete(string id);
        
    }
}
