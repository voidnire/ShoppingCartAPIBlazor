using ShoppingCartAPI.Data;
using ShoppingCartAPI.Repositories;
using ShoppingCartAPI.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShoppingDbContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>(); //addscoped means that same instance can be injected in 
//relevant classes within a particular http request

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();//with this we can see relevant information of the api
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
