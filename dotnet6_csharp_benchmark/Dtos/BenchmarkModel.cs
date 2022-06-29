using dotnet6_csharp_benchmark.Models;

namespace dotnet6_csharp_benchmark.Dtos;

public class BenchmarkModel<T>
{
    public List<T>? Records { get; set; }
    public double ExecuteTime { get; set; }
}