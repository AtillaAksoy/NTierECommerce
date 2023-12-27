using Microsoft.AspNetCore.Mvc;
using NTierECommerce.BLL.Abstracts;

namespace NTierECommerce.MVC.Areas.Admin.Controllers
{
    
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController( ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAllCategories();
            return View(categories);
        }
    }
}
