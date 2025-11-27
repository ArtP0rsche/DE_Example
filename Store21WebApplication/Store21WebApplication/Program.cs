using Store21WebApplication.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<StoreContext>(); // +
builder.Services.AddSession(); // +

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthentication(); // +
app.UseAuthorization();
app.UseSession(); // +

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
