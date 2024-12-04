using Microsoft.EntityFrameworkCore;
using Qara_Gun_1.DAL;

namespace Qara_Gun_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => 
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Mssql"));
            }
            );

            var app = builder.Build();

            app.MapControllerRoute(

                name:"areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

            );

            app.MapControllerRoute(

                name:"Deafult",
                pattern:"{controller=Home}/{action=index}/{id?}"
            );

            //app.

            app.UseStaticFiles();
            app.Run();
        }
    }
}
