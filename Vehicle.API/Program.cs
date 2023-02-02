using Microsoft.Extensions.DependencyInjection;
using Vehicle.Repository;
using Vehicle.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddScoped<BoatRepository>();
builder.Services.AddScoped<CarRepository>();
builder.Services.AddScoped<BusRepository>();


builder.Services.AddControllers();

builder.Services.AddControllers().AddNewtonsoftJson();

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
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
