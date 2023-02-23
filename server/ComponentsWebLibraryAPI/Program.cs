using ComponentsWebLibraryAPI.DataAccess;
using ComponentsWebLibraryAPI.middlewares;
using ComponentsWebLibraryAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

AddServices();
ConfigureDatabase();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseMiddleware<ErrorMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();



void AddServices()
{
    builder.Services.AddRouting(options => options.LowercaseUrls = true);
    builder.Services.AddControllers();
    builder.Services.AddCors();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddScoped<UsersServices>();
    builder.Services.AddScoped<CategoriesServices>();
}

void ConfigureDatabase()
{
    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnectionMySQL");
    builder.Services.AddDbContextPool<MySQLDbContext>(options
        => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
}