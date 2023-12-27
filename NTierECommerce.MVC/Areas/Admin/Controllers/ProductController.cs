using Microsoft.AspNetCore.Mvc;
using NTierECommerce.BLL.Abstracts;

namespace NTierECommerce.MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }
    }
}
