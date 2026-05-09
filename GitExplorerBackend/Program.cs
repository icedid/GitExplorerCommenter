using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Controllers ---
builder.Services.AddControllers();

// --- Database ---
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- Session ---
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// --- Middleware Pipeline ---
app.UseHttpsRedirection();
app.UseSession();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    Seeder.Seed(db);
}

app.Run();