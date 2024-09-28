using AutoMapper;
using DemoProject.WebApi.Dtos.ProductDto;
using DemoProject.WebApi.Models;
using DemoProject.WebApi.Repositories.ProductRepository;
using System.ComponentModel;

namespace DemoProject.WebApi.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProductDto> Create(ProductDto product)
        {
            var p = _mapper.Map<Product>(product);

            var result = await _repository.Create(p);
            return _mapper.Map<ProductDto>(result);
        }

        public Task<object> Delete(string id)
        {
            return _repository.Delete(id);
        }

        public async Task<ProductDto> GetProduct(string id)
        {
            var result = await _repository.GetProduct(id);
            return _mapper.Map<ProductDto>(result);
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            var result = await _repository.GetProducts();
            return _mapper.Map<List<ProductDto>>(result);
        }

        public async Task<ProductDto> Update(ProductDto product)
        {
            var p = _mapper.Map<Product>(product);
            var result = await _repository.Update(p);
            return _mapper.Map<ProductDto>(result);
        }
    }
}
