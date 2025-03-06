    var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // mvc �ablonu tan�tma 

var app = builder.Build();

app.UseStaticFiles(); // wwwroot cal�smas�

app.UseRouting();


// app.MapDefaultControllerRoute();// eskiden g�rd�g�m�z default �ema 
app.MapControllerRoute(
   name: "deafult",
   pattern: "{controller=Meeting}/{action=Index}/{id?}"
   );  
app.Run();
