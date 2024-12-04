using Microsoft.EntityFrameworkCore;
using Qara_Gun_1.Models;

namespace Qara_Gun_1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<TagProducts> tagsProducts { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<ProductImages> ProductsImages { get; set; }
    }
}
