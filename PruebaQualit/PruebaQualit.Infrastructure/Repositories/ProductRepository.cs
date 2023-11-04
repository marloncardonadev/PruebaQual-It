using PruebaQualit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQualit.Infrastructure.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = Enumerable.Range(1, 20).Select(x => new Product
            {
                ProductId = x,
                Name = $"Nombre producto " + x,
                Description = $"Descripcion del producto " + x,
                Price = x * 1000,
                ProductType = $"Tipo de producto " + x,
                Brand = $"Marca del producto " + x
            });

            return products;
        }
    }
}
