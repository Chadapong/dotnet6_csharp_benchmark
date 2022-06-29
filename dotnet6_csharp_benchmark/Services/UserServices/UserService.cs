using System.Diagnostics;
using BCrypt.Net;
using dotnet6_csharp_benchmark.DbContextFolder;
using dotnet6_csharp_benchmark.Dtos;
using dotnet6_csharp_benchmark.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_csharp_benchmark.Services.UserServices;

public class UserService: IUserService
{
    private readonly PostgresqlDbContext _postgresqlDb;

    public UserService( PostgresqlDbContext postgresqlDb)
    {
        _postgresqlDb = postgresqlDb;
    }
    
    public ServiceModel CreateAccount(User model)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ServiceModel serviceModel = new ServiceModel();
        try
        {
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
             _postgresqlDb.Users.Add(model);
             _postgresqlDb.SaveChanges();
          
            stopwatch.Stop();
            serviceModel.ExecuteTime = stopwatch.ElapsedMilliseconds / 1000.0;
            serviceModel.StatusCodes = StatusCodes.Status200OK;
            return serviceModel;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }

    public  ServiceModel<List<UserDto>> GetAllAccount()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ServiceModel<List<UserDto>> serviceModel = new ServiceModel<List<UserDto>>();
        serviceModel.Payload = new List<UserDto>();
        try
        {
            serviceModel.Payload=  _postgresqlDb.Users.Select(item=> new UserDto()
            {
                Username = item.Username,
                Firstname = item.Firstname,
                Lastname = item.Lastname
            }).ToList();
            stopwatch.Stop();
            serviceModel.ExecuteTime = stopwatch.ElapsedMilliseconds / 1000.0;
            serviceModel.StatusCodes = StatusCodes.Status200OK;
            return serviceModel;
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            Console.WriteLine(e);
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }

    public ServiceModel EditAccount(UserDto model)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ServiceModel serviceModel = new ServiceModel();
        try
        {
            var existRecord = _postgresqlDb.Users.Where(item => item.Username == model.Username).FirstOrDefault();
            if (existRecord != null)
            {
               
                existRecord.Firstname = model.Firstname;
                existRecord.Lastname = model.Lastname;
                _postgresqlDb.SaveChanges();
                stopwatch.Stop();
                serviceModel.ExecuteTime = stopwatch.ElapsedMilliseconds / 1000.0;
                serviceModel.StatusCodes = StatusCodes.Status200OK;
            }
            else
            {
                stopwatch.Stop();
                serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            }

            return serviceModel;
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            Console.WriteLine(e);
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }

    public  ServiceModel DeleteAccount(string username)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ServiceModel serviceModel = new ServiceModel();
        try
        {
            var existRecord = _postgresqlDb.Users.Where(item => item.Username == username).FirstOrDefault();
            if (existRecord != null)
            {
                _postgresqlDb.Users.Remove(existRecord);
                _postgresqlDb.SaveChanges();
                stopwatch.Stop();
                serviceModel.ExecuteTime = stopwatch.ElapsedMilliseconds / 1000.0;
                serviceModel.StatusCodes = StatusCodes.Status200OK;
            }
            else
            {
                stopwatch.Stop();
                serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            }
            return serviceModel;
          
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            Console.WriteLine(e);
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }
}