using Microsoft.AspNetCore.Hosting;
using TakeAway.DiscountService.Services.Abstractions;
using TakeAway.DiscountService.Services.Concretions;
using TakeAway.DiscountService.Settings.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DiscountServiceMsSqlDbContext>();
builder.Services.AddScoped<DapperOrmDbConnection>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<ICouponService, CouponService>();

builder.Services.AddControllers();
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
