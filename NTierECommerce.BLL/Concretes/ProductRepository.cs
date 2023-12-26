using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class ProductRepository:IProductRepository
    {
        private readonly IRepository<Product> _productRep;

        public ProductRepository(IRepository<Product> productRep)
        {
            _productRep = productRep;
        }

        public async Task<string> CreateProduct(Product entity)
        {
            return await _productRep.Create(entity);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRep.GetAll();
        }

        public async Task<Product> GetProductWithById(int id)
        {
            return await _productRep.GetById(id);
        }

        public async Task<string> UpdateProduct(Product entity)
        {
            return await _productRep.Update(entity);
        }
    }
}
