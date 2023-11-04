using Microsoft.EntityFrameworkCore;
using PruebaQualit.Core.Entities;
using PruebaQualit.Core.Interfaces;
using PruebaQualit.Infrastructure.Data;

namespace PruebaQualit.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly PruebaQualitContext _context;
        public ProductRepository(PruebaQualitContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            return product;
        }

        public async Task InsertProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var currentProduct = await GetProduct(product.Id);
            currentProduct.Name = product.Name;
            currentProduct.Description = product.Description;
            currentProduct.Price = product.Price;
            currentProduct.ProductType = product.ProductType;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var currentProduct = await GetProduct(id);
            _context.Products.Remove(currentProduct);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
