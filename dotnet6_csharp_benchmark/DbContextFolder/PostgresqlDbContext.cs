using dotnet6_csharp_benchmark.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_csharp_benchmark.DbContextFolder;

public class PostgresqlDbContext: DbContext
{
    public PostgresqlDbContext(DbContextOptions<PostgresqlDbContext> options) : base(options)
    {
        
    }
    public DbSet<HealthCare_0> HealthCares_0 { get; set; }
    public DbSet<HealthCare_1> HealthCares_1 { get; set; }
    public DbSet<HealthCare_2> HealthCares_2 { get; set; }
    public DbSet<HealthCare_3> HealthCares_3 { get; set; }
    public DbSet<HealthCare_4> HealthCares_4 { get; set; }
    public DbSet<User>Users { get; set; }
}