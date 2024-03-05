namespace WebApp_Uhrzeit;


public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Configure the App as MVC-App
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseStaticFiles();
        app.UseRouting();
        
        // app.MapGet("/", () => "Hello World!");
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );
        app.Run();
    }
}