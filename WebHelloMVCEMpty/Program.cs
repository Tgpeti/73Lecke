namespace WebHelloMVCEMpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllers();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Hello}/{action=Index}/{id?}");

           app.UseStaticFiles();

            app.Run();
            
        }
    }
}