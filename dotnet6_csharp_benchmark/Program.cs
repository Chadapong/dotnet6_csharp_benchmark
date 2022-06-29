using dotnet6_csharp_benchmark.DbContextFolder;
using dotnet6_csharp_benchmark.Services.HealthCareServices;
using dotnet6_csharp_benchmark.Services.UserServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PostgresqlDbContext>(option =>
    option.UseNpgsql(builder.Configuration.GetConnectionString("postgresqlConnection"))
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<IHealthCareInfoService, HealthCareInfoService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// plugin CORS
app.UseCors(opt => opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();