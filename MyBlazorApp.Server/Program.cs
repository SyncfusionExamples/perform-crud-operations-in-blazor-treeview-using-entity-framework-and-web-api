using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Shared.DataAccess;

namespace MyBlazorApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
            builder.Services.AddDbContext<OrganizationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDatabase")));
            builder.Services.AddScoped<IOrganizationDataAccessLayer, OrganizationDataAccessLayer>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}
