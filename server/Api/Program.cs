using Api.Middleware;
using AutoMapper;
using Domain.Repositories;
using Domain.Utilities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;
using Services;
using Services.Abstractions;
using Services.Mapping;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", config =>
    {
        config.AllowAnyHeader();
        config.AllowAnyMethod();
        config.AllowAnyOrigin();
        config.SetPreflightMaxAge(TimeSpan.FromHours(1));
    });
});
var mapperConfig = ModelMapper.Configure();
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IServiceManager, ServiceManager>();

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IUtilityManager, UtilityManager>();

var connectionString = builder.Configuration.GetConnectionString("Default"); 
builder.Services.AddDbContext<RepositoryDbContext>(
                options => options.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString),
                    mySqlServerOptions => mySqlServerOptions.MigrationsAssembly("Persistence")
                    ));

builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

app.Services.UseAutoMigration<RepositoryDbContext>();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
