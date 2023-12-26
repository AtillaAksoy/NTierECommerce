using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Abstracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        Task<Product> GetProductWithById(int id);

        Task<string> CreateProduct(Product entity);
        Task<string> UpdateProduct(Product entity);
    }
}
