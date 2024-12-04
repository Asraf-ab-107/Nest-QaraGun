using Qara_Gun_1.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Qara_Gun_1.Models
{
    public class Category : BaseClass
    {
        [Required,StringLength(10,ErrorMessage ="ad 20 simvoldan cox olmaz")]
        public string Name {  get; set; }
        public List<Product> Products { get; set; }
    }
}
