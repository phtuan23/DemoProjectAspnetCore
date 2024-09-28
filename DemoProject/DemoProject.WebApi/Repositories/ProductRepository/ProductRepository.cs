using DemoProject.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.WebApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(
            AppDbContext appDbContext
        ) {
            _appDbContext = appDbContext;
        }  

        public async Task<Product> Create(Product product)
        {
            var result = await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<object> Delete(string id)
        {

            var p = await GetProduct(id);
            if (p == null)
            {
                return new { message = "Not found Product" };
            }
            _appDbContext.Products.Remove(p);
            await _appDbContext.SaveChangesAsync();
            return new { message = "Product removed" };
        }

        public async Task<Product> GetProduct(string id)
        {
            var product = await _appDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _appDbContext.Products.ToListAsync();
            return products;
        }

        public Task<Product> Update(Product product)
        {
            _appDbContext.Update(product);
            _appDbContext.SaveChanges();
            return Task.FromResult(product);
        }
    }
}
