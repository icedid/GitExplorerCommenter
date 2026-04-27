using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Controllers ---
builder.Services.AddControllers();

// --- Database ---
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

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

app.Run();