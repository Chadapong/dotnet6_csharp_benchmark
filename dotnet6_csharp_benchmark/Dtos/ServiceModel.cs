namespace dotnet6_csharp_benchmark.Dtos;

public class ServiceModel
{
    public int StatusCodes { get; set; }
    public double? ExecuteTime { get; set; }

}

public class ServiceModel<T>: ServiceModel
{
    public T Payload { get; set; }

}