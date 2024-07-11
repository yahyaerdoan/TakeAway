using Microsoft.Extensions.Options;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;
using TakeAway.CatalogService.Services.CategoryService.Concretions;
using TakeAway.CatalogService.Settings.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.Configure<CatologServiceMongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddScoped<ICatologServiceMongoDbContext, CatologServiceMongoDbContext>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<CatologServiceMongoDbSettings>>().Value;
    return new CatologServiceMongoDbContext(settings);
});
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ICategoryService, CategoryService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
