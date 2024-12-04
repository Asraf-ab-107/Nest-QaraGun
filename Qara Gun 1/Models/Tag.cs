using Qara_Gun_1.Models.BaseEntity;

namespace Qara_Gun_1.Models
{
    public class Tag:BaseClass
    {
        public string Name { get; set; }
        public List<TagProducts> tagProducts { get; set; }
         
    }
}
