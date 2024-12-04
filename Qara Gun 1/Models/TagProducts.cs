using Qara_Gun_1.Models.BaseEntity;

namespace Qara_Gun_1.Models
{
    public class TagProducts :BaseClass
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
