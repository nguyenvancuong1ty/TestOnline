using Application;
using Application.Class;
using Microsoft.EntityFrameworkCore;
using TestOnline_Data.EF;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
// Add services to the container.
services.AddControllersWithViews();
services.AddHttpContextAccessor();
services.AddDbContext<AppDBContext>(options =>
        options.UseSqlServer("Data Source=DESKTOP-FLF2O2F;Database=TestOnline;Integrated Security=True;Trust Server Certificate=True"));
services.AddAutoMapper(typeof(MapperProfiles));
services.AddOptions();
services.AddTransient<IClassService, ClassService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
