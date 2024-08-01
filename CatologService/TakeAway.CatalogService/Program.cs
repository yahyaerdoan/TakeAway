using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;
using TakeAway.CatalogService.Services.CategoryService.Concretions;
using TakeAway.CatalogService.Services.DailyDiscountService.Abstractions;
using TakeAway.CatalogService.Services.DailyDiscountService.Concretions;
using TakeAway.CatalogService.Services.ProductService.Abstractions;
using TakeAway.CatalogService.Services.ProductService.Concretions;
using TakeAway.CatalogService.Services.SliderService.Abstractions;
using TakeAway.CatalogService.Services.SliderService.Concretions;
using TakeAway.CatalogService.Settings.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "ResourceCatalog1";
    opt.RequireHttpsMetadata = false;
});

builder.Services.Configure<CatologServiceMongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddScoped<ICatologServiceMongoDbContext, CatologServiceMongoDbContext>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<CatologServiceMongoDbSettings>>().Value;
    return new CatologServiceMongoDbContext(settings);
});
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDailyDiscountService, DailyDiscountService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISliderService, SliderService>();

#region Default Services
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
