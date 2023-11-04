using PruebaQualit.Core.Entities;

namespace PruebaQualit.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task InsertProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
