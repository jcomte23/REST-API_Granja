using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using REST_API_Granja.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var conectionDB = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(conectionDB, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Version 1
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Granja",
        Description = "API version 1 for managing farm animals. This version includes basic CRUD operations for animal types and animals.",
        TermsOfService = new Uri("https://github.com/jcomte23/REST-API_Granja/blob/main/LICENSE"),
        Contact = new OpenApiContact
        {
            Name = "Javier Cómbita Téllez",
            Email = "jcomte23@outlook.com",
            Url = new Uri("https://github.com/jcomte23")
        },
        License = new OpenApiLicense
        {
            Name = "GNU General Public License v3.0",
            Url = new Uri("https://github.com/jcomte23/REST-API_Granja/blob/main/LICENSE")
        }
    });

    // Version 2
    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = "API Granja",
        Description = "API version 2. This version includes new features and improvements over version 1. For detailed changes, check the changelog.",
        TermsOfService = new Uri("https://github.com/jcomte23/REST-API_Granja/blob/main/LICENSE"),
        Contact = new OpenApiContact
        {
            Name = "Javier Cómbita Téllez",
            Email = "jcomte23@outlook.com",
            Url = new Uri("https://github.com/jcomte23")
        },
        License = new OpenApiLicense
        {
            Name = "GNU General Public License v3.0",
            Url = new Uri("https://github.com/jcomte23/REST-API_Granja/blob/main/LICENSE")
        }
    });

    // Enable annotations for better Swagger documentation
    options.EnableAnnotations();
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Version 2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
