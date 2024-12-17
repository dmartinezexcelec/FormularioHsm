using Hsm;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registra ApplicationDbContext en el contenedor de dependencias
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // O usa otro proveedor de base de datos según tu configuración

// Agrega servicios para controladores y vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura las rutas predeterminadas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
