FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dotnet6_csharp_benchmark/dotnet6_csharp_benchmark.csproj", "dotnet6_csharp_benchmark/"]
RUN dotnet restore "dotnet6_csharp_benchmark/dotnet6_csharp_benchmark.csproj"
COPY . .
WORKDIR "/src/dotnet6_csharp_benchmark"
RUN dotnet build "dotnet6_csharp_benchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dotnet6_csharp_benchmark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet6_csharp_benchmark.dll"]
