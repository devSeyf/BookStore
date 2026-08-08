using BookStore.Models;
using BookStore.Models.Repositories;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllersWithViews();

        
             builder.Services.AddSingleton<IBookstoreRepository<Book>, BookRepository>();
            


            builder.Services.AddSingleton<
                IBookstoreRepository<Author>,
                AuthorRepository>();

            
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
            pattern: "{controller=Author}/{action=Index}/{id?}");


            app.Run();
        }
    }
}