using dotnet6_csharp_benchmark.Dtos;
using dotnet6_csharp_benchmark.Models;

namespace dotnet6_csharp_benchmark.Services.UserServices;

public interface IUserService
{
    ServiceModel CreateAccount(User model);
    ServiceModel<List<UserDto>> GetAllAccount();
    ServiceModel EditAccount(UserDto model);
    ServiceModel DeleteAccount(string username);
}