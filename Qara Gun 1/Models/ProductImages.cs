using Qara_Gun_1.Models.BaseEntity;

namespace Qara_Gun_1.Models
{
    public class ProductImages:BaseClass
    {
        public string FirstImgUrl { get; set; }
        public string ImgUrl {  get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
