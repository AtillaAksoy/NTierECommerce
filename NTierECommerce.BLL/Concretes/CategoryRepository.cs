using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private IRepository<Category> _categoryRep;
        public CategoryRepository(IRepository<Category> categoryRep)
        {
            _categoryRep = categoryRep;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRep.GetAll();
        }
    }
}
