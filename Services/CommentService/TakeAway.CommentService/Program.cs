using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TakeAway.CommentService.DataAccessLayer.Settings.Context;
using TakeAway.CommentService.Services.Abstractions;
using TakeAway.CommentService.Services.Concretions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CommentContext>(option => { option.UseNpgsql(connectionString); });

builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
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
