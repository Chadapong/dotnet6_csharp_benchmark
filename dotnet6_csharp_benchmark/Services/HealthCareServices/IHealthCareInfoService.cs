using dotnet6_csharp_benchmark.Dtos;
using dotnet6_csharp_benchmark.Models;

namespace dotnet6_csharp_benchmark.Services.HealthCareServices;

public interface IHealthCareInfoService
{
    ServiceModel<BenchmarkModel<HealthCare_4>> GetVeryComplexQuery();
    ServiceModel<BenchmarkModel<HealthCare_4>> GetComplexQuery();
}