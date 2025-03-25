using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);


builder.Services.AddDbContext<StoreDbContext>(options => {
    options.UseSqlite(builder.Configuration["ConnectionStrings:StoreDbConnection"]);
});

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapControllerRoute("products_in_category", "products/{category?}", new { controller = "Home", action = "Index" });
app.MapControllerRoute("product_details", "{name}", new { controller = "Home", action = "Details" });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
