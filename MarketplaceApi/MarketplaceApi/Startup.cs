using MarketplaceApi.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var originesPermitidos = builder.Configuration.GetValue<string>("originesPermitidos")!.Split(',');
builder.Services.AddCors(optiones => {
    optiones.AddDefaultPolicy(politica => {
        politica.WithOrigins(originesPermitidos).AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddDbContext<MarketplaceContext>(opciones =>

opciones.UseSqlServer("name=DefaultConnection"));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();

