using CaploitteAPI.Model.DataHandler;
using CaploitteAPI.Model;
using CaploitteAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(builder.Configuration["connectionString:EmployeeDB"]));
builder.Services.AddScoped<IDataHandlerRepository<Employee>, EmployeeHandler>();
builder.Services.AddScoped<IUserLoginHandlerRepository<UserLogin>, UserLoginHandler>();
builder.Services.AddScoped<IDataHandlerRepository<EmployeeSalaryDetails>, EmployeeSalaryHandler>();


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
