using Microsoft.AspNetCore.Mvc;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Entities;
using NTierECommerce.MVC.Models;
using System.Diagnostics;

namespace NTierECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;//IProductRepository'i dependency inject etme işlemi.
        }

        public IActionResult Index()
        {
            return View();
        }

        #region NOT:
        /*
            NOT: 
                    ProductController || CategoryController oluşturup yapmak daha doğru olurdu fakat böyle bir özel istek olmadığından dolayı
                    yapmadım.
                    View'lar yapıp sonuçları listeleyebilir ViewModel oluşturarak sayfada yapılan istekleri gerçekleştirebilirdim fakat
                    sınıfta yapılacak olan projeye uymayacağını düşündüğüm için sayfaları(View) yapmadım.
         */
        #endregion



        //CATEGORY-------------------------------------------------------------------------------------------------------
        public IActionResult CategoryList()
        {
            var categories = _categoryRepository.GetAllCategories();
            return View(categories);
        }
        public async Task<IActionResult> GetCategoryId(int id) 
        {
            var category = await _categoryRepository.GetCategoryWithById(id);
            return View(category);
        }

        public async Task<IActionResult> CreateCategory(Category entity) //burada viewdan ViewModel klasöründeki CategoryVM tipinde oluşturulmuş bir nesne olmalı
        {
            //bu bölümde Category class'ını temsilen bir view model oluşturulacak
            //bu oluşturulan viewModel nesnesi bu metot a parametre olarak verilecek 
            //bu parametreden alınan ViewModel nesnesi içersindeki property değerleri 
            //Category tipinde oluşturulan bir category nesnesine set edildikten sonra
            //aşşağıdaki adımlar izlenecek:
            string sonuc = await _categoryRepository.CreateCategory(entity); //var sonuc = string bir mesaj dönecek olumlu ise olumlu mesajı
            //olumsuz ise ex.message yani hata mesajı bir tempdata içersine gelen sonucu yazdırıp view da gösterebiliriz.
            return View();
        }
        //miras alınan sınıflara bağımlı olan metotlar task async await olduğu için controllerda da bu metotları asenkron yapmam gerekti(yapmasaydımda çalışıyordu fakat hata almamak adına.)
        public async Task<IActionResult> UpdateCategory(Category entity)//VMnesnesi
        {
            //VMnesnesini categori klasından üretilmiş bir nesneye çevirmek için kullandığımız Utils Metotu
            string sonuc = await _categoryRepository.UpdateCategory(entity);//oluşturduğumuz category nesnesini UpdateCategory methodunun parametresine verdik.
            TempData["updateCategory"]= sonuc;//dönen sonucu tempdata ya atadık(daha sonra bunu view da alert olarak bastırıcaz)
            return RedirectToAction("Index");
        }

        //PRODUCT-------------------------------------------------------------------------------------------------------
        public IActionResult ProductList()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }
        public async Task<IActionResult> GetProductId(int id)
        {
            var product = await _productRepository.GetProductWithById(id);
            return View(product);
        }
        public async Task<IActionResult> CreateProdut(Product entity) 
        {
            string sonuc = await _productRepository.CreateProduct(entity);
            return View();
        }
        public async Task<IActionResult> UpdateProduct(Product entity)
        {
            string sonuc = await _productRepository.UpdateProduct(entity);
            TempData["updateProduct"] = sonuc;
            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------------------------------------------------

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}