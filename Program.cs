using Microsoft.EntityFrameworkCore;
using Task1.Context;
using Task1.External;
using Task1.IRepositroy;
using Task1.IServices;
using Task1.Repository;
using Task1.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<TaskContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("Task"));
});
// Add services to the container.

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IOrderHeaderRepository, OrderHeaderRepository>();
builder.Services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOrderHeaderService, OrderHeaderService>();
builder.Services.AddScoped<IOrderDetailsService, OrderDetailsService>();

builder.Services.AddAutoMapper(typeof(MappingConfigration));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Enable CORS
builder.Services.AddCors(corsOptions => {
    corsOptions.AddPolicy("MyPolicy", corsPolicyBuilder =>
    {
        corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
    
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

