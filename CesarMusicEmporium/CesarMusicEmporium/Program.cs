using Microsoft.EntityFrameworkCore;
using CesarMusicEmporium.Data;
using CesarMusicEmporium.Models;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Floppa\\Desktop\\YET ANOTHER TEST\\Database3.accdb;";
var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "Database3.accdb");
var connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseJet(connectionString));

builder.Services.AddControllers().AddControllersAsServices();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// Add services to the container.
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

// Enable CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
