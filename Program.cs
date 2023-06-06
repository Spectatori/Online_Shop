using Microsoft.EntityFrameworkCore;
using Online_Shop.Data;
using Online_Shop.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkMySql().AddDbContext<ClothesDbContext>(options =>
{
    var connectionstring = builder.Configuration.GetConnectionString("ClothesDb");
    options.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring));
});
builder.Services.AddScoped<ClothesService>();

//response compression
/*builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true; // Enable compression for HTTPS requests
    options.Providers.Add<GzipCompressionProvider>();
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "text/plain" }); //text compression
});*/

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

//app.UseResponseCompression();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();