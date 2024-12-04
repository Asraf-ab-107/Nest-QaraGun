using Qara_Gun_1.Models;

namespace Qara_Gun_1.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public List<ProductImages> ProductsImages { get; set; }

    }
}
