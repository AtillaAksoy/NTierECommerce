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

        public async Task<string> CreateCategory(Category entity)
        {
            return await _categoryRep.Create(entity);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRep.GetAll();
        }

        //hata oluşabilir ve değer null gelebilir bu yüzden async metot olmalı o sebeple Task<Category> içersinde
        public async Task<Category> GetCategoryWithById(int id)
        {
            return await _categoryRep.GetById(id);
        }

        public async Task<string> UpdateCategory(Category entity)
        {
            return await _categoryRep.Update(entity);
        }
    }
}
