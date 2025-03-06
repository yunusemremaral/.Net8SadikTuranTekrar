    var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // mvc þablonu tanýtma 

var app = builder.Build();

app.UseStaticFiles(); // wwwroot calýsmasý

app.UseRouting();


// app.MapDefaultControllerRoute();// eskiden gördügümüz default þema 
app.MapControllerRoute(
   name: "deafult",
   pattern: "{controller=Meeting}/{action=Index}/{id?}"
   );  
app.Run();
