using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqLite;
using Jade.Tiger.Data

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Servies.AddDbContext<StoreContext>(options =>
{
    options.UseSqLite("Data Source=../store.db",
    m => m.MigrationsAssembly ("Jade.Tiger.Api"));
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => 
    {
        builder.WithOrigins("http://localhost:5173")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddSwaggerGen(c =>
{
    c. SwaggerDoc("v1", new OpenApiInfo { Title = "Your Project Name API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(char =>
{
    c. SwaggerEndpoint("/swagger/v1/swagger.json", "Jade.Tiger API V1");
});
app.UseCors();

app.MapControllers();

app.Run();
