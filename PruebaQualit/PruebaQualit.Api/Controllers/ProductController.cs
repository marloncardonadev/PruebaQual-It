using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaQualit.Api.Response;
using PruebaQualit.Core.DTOs;
using PruebaQualit.Core.Entities;
using PruebaQualit.Core.Interfaces;

namespace PruebaQualit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetProducts();
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            var response = new ApiResponse<IEnumerable<ProductDto>>(productsDto);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetProduct(id);
            var productDto = _mapper.Map<ProductDto>(product);
            var response = new ApiResponse<ProductDto>(productDto);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.InsertProduct(product);
            productDto = _mapper.Map<ProductDto>(product);
            var response = new ApiResponse<ProductDto>(productDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PutProduct(int id, ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.Id = id;
            var result = await _productRepository.UpdateProduct(product);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _productRepository.DeleteProduct(id);
            var response = new ApiResponse<bool>(result);

            return Ok(response);
        }
    }
}
