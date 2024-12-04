using Qara_Gun_1.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Qara_Gun_1.Models
{
    public class Product:BaseClass
    {
        public string ProductBadges {  get; set; }
        public string Category { get; set; }
        [Required, StringLength(15, ErrorMessage = "ad 15 simvoldan cox olmaz")] 
        public string Name { get; set; }
        public double Price { get; set; }
        public Category category { get; set; }
        public List<TagProducts> TagProducts { get; set;}
        public List<ProductImages> ProductImages { get; set;}
        
    };
}
