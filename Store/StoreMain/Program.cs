using Microsoft.EntityFrameworkCore;
using StoreData.ConnectDB;
using StoreServices.Interface;
using StoreServices.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProductRepository, ProductRepository>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StoreAPIConnection"), b => b.MigrationsAssembly("StoreMain")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy =>
policy.WithOrigins("http://localhost:3000")
.AllowAnyHeader()
.AllowAnyMethod()
/*.AllowAnyOrigin()*/);

app.UseAuthorization();

app.MapControllers();

app.Run();
