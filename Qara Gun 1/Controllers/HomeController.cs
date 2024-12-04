using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qara_Gun_1.DAL;
using Qara_Gun_1.Models;
using Qara_Gun_1.ViewModels;

namespace Qara_Gun_1.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  async Task<IActionResult> Index()
        {

            List<Product> products = await _dbContext.products.ToListAsync();
            List<Category> categories = await _dbContext.categories.ToListAsync();
            List<Tag> tags = await _dbContext.tags.ToListAsync();
            List<ProductImages> productsimages = await _dbContext.ProductsImages.ToListAsync();
            List<Slider> sliders = await _dbContext.sliders.ToListAsync();

            HomeVm vm = new HomeVm()
            {
                Products = products,
                Categories = categories,
                Tags = tags,
                ProductsImages = productsimages,
                Sliders = sliders
            };

            return View(vm);
        }
    }
}
