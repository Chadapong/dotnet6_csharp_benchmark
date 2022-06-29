using System.Diagnostics;
using System.Security.Cryptography;
using dotnet6_csharp_benchmark.DbContextFolder;
using dotnet6_csharp_benchmark.Dtos;
using dotnet6_csharp_benchmark.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_csharp_benchmark.Services.HealthCareServices;

public class HealthCareInfoService : IHealthCareInfoService
{
    private readonly PostgresqlDbContext _postgresqlDb;
    private Task<ServiceModel<List<HealthCare_0>>> _getVeryComplexQuery;
    public HealthCareInfoService(PostgresqlDbContext postgresqlDb)
    {
        _postgresqlDb = postgresqlDb;
    }


    public ServiceModel<BenchmarkModel<HealthCare_4>> GetVeryComplexQuery()
    {
        Stopwatch stopwatch = new Stopwatch();
      
        ServiceModel<BenchmarkModel<HealthCare_4>> serviceModel = new ServiceModel<BenchmarkModel<HealthCare_4>>();
        serviceModel.Payload = new BenchmarkModel<HealthCare_4>();
        serviceModel.Payload.Records = new List<HealthCare_4>();
        Double avgExeTime = 0.0;
        try
        {
            int i = 0;
                 stopwatch.Start();
             _postgresqlDb.HealthCares_0.FromSqlRaw(@$"SELECT * FROM health_cares_{i}
             WHERE
             heart_disease=true AND 
             bmi = (SELECT ROUND(avgBmi::numeric,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i} WHERE sex='Female' AND age_category=(SELECT MIN(age_category) FROM health_cares_{i}) AND sleep_time=(SELECT ROUND(avgSleep::numeric,0) FROM (SELECT AVG(sleep_time) as avgSleep FROM health_cares_{i}) as bmi_avg_t)) as avgBmiT) AND
             sleep_time = (SELECT ROUND(avg_sleep::numeric,0) FROM (SELECT AVG(sleep_time) as avg_sleep FROM health_cares_{i} WHERE sex='Female' AND bmi=(SELECT AVG(avg_bmi) FROM (SELECT race, ROUND(avg_bmi::numeric,0) as avg_bmi FROM (SELECT race,AVG(bmi) as avg_bmi FROM health_cares_{i} GROUP BY race) as complex_query_cond2) as round_AvgSleepT)) as roundAvgSleepT) AND
             sex= (SELECT sex FROM(SELECT COUNT(sex) as numberPP,sex FROM health_cares_{i} GROUP BY sex) as numberPPT WHERE numberPP= (SELECT MAX(totalPP) FROM (SELECT COUNT(sex) as totalPP,sex FROM health_cares_{i} GROUP BY sex) as maxPPT)) AND
             age_category = (SELECT MAX(DISTINCT age_category) FROM health_cares_{i} WHERE bmi = (SELECT ROUND(avgBmi,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i}) as avgBmiT)) AND
             physical_health = (SELECT ROUND(avgPh::numeric,0) FROM (SELECT AVG(physical_health) as avgPh FROM health_cares_{i}) as roundPH)  ORDER BY index").ToList();
            stopwatch.Stop();
            Console.WriteLine(avgExeTime);
            avgExeTime = avgExeTime + (stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine(avgExeTime);
            
             i = 1;
            stopwatch.Start();
             _postgresqlDb.HealthCares_1.FromSqlRaw(@$"SELECT * FROM health_cares_{i}
             WHERE
             heart_disease=true AND 
             bmi = (SELECT ROUND(avgBmi::numeric,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i} WHERE sex='Female' AND age_category=(SELECT MIN(age_category) FROM health_cares_{i}) AND sleep_time=(SELECT ROUND(avgSleep::numeric,0) FROM (SELECT AVG(sleep_time) as avgSleep FROM health_cares_{i}) as bmi_avg_t)) as avgBmiT) AND
             sleep_time = (SELECT ROUND(avg_sleep::numeric,0) FROM (SELECT AVG(sleep_time) as avg_sleep FROM health_cares_{i} WHERE sex='Female' AND bmi=(SELECT AVG(avg_bmi) FROM (SELECT race, ROUND(avg_bmi::numeric,0) as avg_bmi FROM (SELECT race,AVG(bmi) as avg_bmi FROM health_cares_{i} GROUP BY race) as complex_query_cond2) as round_AvgSleepT)) as roundAvgSleepT) AND
             sex= (SELECT sex FROM(SELECT COUNT(sex) as numberPP,sex FROM health_cares_{i} GROUP BY sex) as numberPPT WHERE numberPP= (SELECT MAX(totalPP) FROM (SELECT COUNT(sex) as totalPP,sex FROM health_cares_{i} GROUP BY sex) as maxPPT)) AND
             age_category = (SELECT MAX(DISTINCT age_category) FROM health_cares_{i} WHERE bmi = (SELECT ROUND(avgBmi,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i}) as avgBmiT)) AND
             physical_health = (SELECT ROUND(avgPh::numeric,0) FROM (SELECT AVG(physical_health) as avgPh FROM health_cares_{i}) as roundPH)  ORDER BY index").ToList();
            stopwatch.Stop();
            Console.WriteLine(avgExeTime);
            avgExeTime = avgExeTime + (stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine(avgExeTime);
            
            i = 2;
            stopwatch.Start();
              _postgresqlDb.HealthCares_2.FromSqlRaw(@$"SELECT * FROM health_cares_{i}
             WHERE
             heart_disease=true AND 
             bmi = (SELECT ROUND(avgBmi::numeric,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i} WHERE sex='Female' AND age_category=(SELECT MIN(age_category) FROM health_cares_{i}) AND sleep_time=(SELECT ROUND(avgSleep::numeric,0) FROM (SELECT AVG(sleep_time) as avgSleep FROM health_cares_{i}) as bmi_avg_t)) as avgBmiT) AND
             sleep_time = (SELECT ROUND(avg_sleep::numeric,0) FROM (SELECT AVG(sleep_time) as avg_sleep FROM health_cares_{i} WHERE sex='Female' AND bmi=(SELECT AVG(avg_bmi) FROM (SELECT race, ROUND(avg_bmi::numeric,0) as avg_bmi FROM (SELECT race,AVG(bmi) as avg_bmi FROM health_cares_{i} GROUP BY race) as complex_query_cond2) as round_AvgSleepT)) as roundAvgSleepT) AND
             sex= (SELECT sex FROM(SELECT COUNT(sex) as numberPP,sex FROM health_cares_{i} GROUP BY sex) as numberPPT WHERE numberPP= (SELECT MAX(totalPP) FROM (SELECT COUNT(sex) as totalPP,sex FROM health_cares_{i} GROUP BY sex) as maxPPT)) AND
             age_category = (SELECT MAX(DISTINCT age_category) FROM health_cares_{i} WHERE bmi = (SELECT ROUND(avgBmi,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i}) as avgBmiT)) AND
             physical_health = (SELECT ROUND(avgPh::numeric,0) FROM (SELECT AVG(physical_health) as avgPh FROM health_cares_{i}) as roundPH)  ORDER BY index").ToList();
            stopwatch.Stop();
            Console.WriteLine(avgExeTime);
            avgExeTime = avgExeTime + (stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine(avgExeTime);
            
            i = 3;
            stopwatch.Start();
            _postgresqlDb.HealthCares_3.FromSqlRaw(@$"SELECT * FROM health_cares_{i}
             WHERE
             heart_disease=true AND 
             bmi = (SELECT ROUND(avgBmi::numeric,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i} WHERE sex='Female' AND age_category=(SELECT MIN(age_category) FROM health_cares_{i}) AND sleep_time=(SELECT ROUND(avgSleep::numeric,0) FROM (SELECT AVG(sleep_time) as avgSleep FROM health_cares_{i}) as bmi_avg_t)) as avgBmiT) AND
             sleep_time = (SELECT ROUND(avg_sleep::numeric,0) FROM (SELECT AVG(sleep_time) as avg_sleep FROM health_cares_{i} WHERE sex='Female' AND bmi=(SELECT AVG(avg_bmi) FROM (SELECT race, ROUND(avg_bmi::numeric,0) as avg_bmi FROM (SELECT race,AVG(bmi) as avg_bmi FROM health_cares_{i} GROUP BY race) as complex_query_cond2) as round_AvgSleepT)) as roundAvgSleepT) AND
             sex= (SELECT sex FROM(SELECT COUNT(sex) as numberPP,sex FROM health_cares_{i} GROUP BY sex) as numberPPT WHERE numberPP= (SELECT MAX(totalPP) FROM (SELECT COUNT(sex) as totalPP,sex FROM health_cares_{i} GROUP BY sex) as maxPPT)) AND
             age_category = (SELECT MAX(DISTINCT age_category) FROM health_cares_{i} WHERE bmi = (SELECT ROUND(avgBmi,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i}) as avgBmiT)) AND
             physical_health = (SELECT ROUND(avgPh::numeric,0) FROM (SELECT AVG(physical_health) as avgPh FROM health_cares_{i}) as roundPH)  ORDER BY index").ToList();
            stopwatch.Stop();
            Console.WriteLine(avgExeTime);
            avgExeTime = avgExeTime + (stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine(avgExeTime);
            
            i = 4;
            stopwatch.Start();
            serviceModel.Payload.Records =  _postgresqlDb.HealthCares_4.FromSqlRaw(@$"SELECT * FROM health_cares_{i}
             WHERE
             heart_disease=true AND 
             bmi = (SELECT ROUND(avgBmi::numeric,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i} WHERE sex='Female' AND age_category=(SELECT MIN(age_category) FROM health_cares_{i}) AND sleep_time=(SELECT ROUND(avgSleep::numeric,0) FROM (SELECT AVG(sleep_time) as avgSleep FROM health_cares_{i}) as bmi_avg_t)) as avgBmiT) AND
             sleep_time = (SELECT ROUND(avg_sleep::numeric,0) FROM (SELECT AVG(sleep_time) as avg_sleep FROM health_cares_{i} WHERE sex='Female' AND bmi=(SELECT AVG(avg_bmi) FROM (SELECT race, ROUND(avg_bmi::numeric,0) as avg_bmi FROM (SELECT race,AVG(bmi) as avg_bmi FROM health_cares_{i} GROUP BY race) as complex_query_cond2) as round_AvgSleepT)) as roundAvgSleepT) AND
             sex= (SELECT sex FROM(SELECT COUNT(sex) as numberPP,sex FROM health_cares_{i} GROUP BY sex) as numberPPT WHERE numberPP= (SELECT MAX(totalPP) FROM (SELECT COUNT(sex) as totalPP,sex FROM health_cares_{i} GROUP BY sex) as maxPPT)) AND
             age_category = (SELECT MAX(DISTINCT age_category) FROM health_cares_{i} WHERE bmi = (SELECT ROUND(avgBmi,0) FROM (SELECT AVG(bmi) as avgBmi FROM health_cares_{i}) as avgBmiT)) AND
             physical_health = (SELECT ROUND(avgPh::numeric,0) FROM (SELECT AVG(physical_health) as avgPh FROM health_cares_{i}) as roundPH)  ORDER BY index").ToList();
            stopwatch.Stop();
            Console.WriteLine(avgExeTime);
            avgExeTime = avgExeTime + (stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine(avgExeTime);


            avgExeTime = avgExeTime / 5.0;
            serviceModel.Payload.ExecuteTime = avgExeTime;
            serviceModel.StatusCodes = StatusCodes.Status200OK;
            return serviceModel;
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            Console.WriteLine(e);
            serviceModel.Payload.Records =null;
            serviceModel.Payload.ExecuteTime = 0;
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }


    public ServiceModel<BenchmarkModel<HealthCare_4>> GetComplexQuery()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ServiceModel<BenchmarkModel<HealthCare_4>> serviceModel = new ServiceModel<BenchmarkModel<HealthCare_4>>();
        serviceModel.Payload = new BenchmarkModel<HealthCare_4>();
        serviceModel.Payload.Records = new List<HealthCare_4>();
        Double avgExeTime = 0.0;
        try
        {

            int i = 0;
            
                stopwatch.Start();
                 _postgresqlDb.HealthCares_0.FromSqlRaw(@$"SELECT * FROM health_cares_{i} 
                WHERE 
                    bmi = (SELECT CAST(bmiValue as double precision) FROM (SELECT ROUND(avgBmi::numeric,0) as bmiValue FROM(SELECT AVG(bmi) as avgBmi FROM health_cares_{i}  ) as bmiTable) as bmiT) AND 
                    physical_health = (SELECT ROUND(avgPhy::numeric,0) FROM(SELECT AVG(physical_health) as avgPhy FROM health_cares_{i}  ) as avgPhyT) AND 
                    mental_health = (SELECT ROUND(avgMental::numeric,0) FROM(SELECT AVG(mental_health) as avgMental FROM health_cares_{i}  ) as avgMentalT) AND 
                    sleep_time = (SELECT ROUND(avgSleep::numeric,0) as avgRoundSleep FROM (SELECT gen_health, AVG(sleep_time) as avgSleep FROM health_cares_{i}   GROUP BY gen_health) as T WHERE T.gen_health='Very good') 
                ORDER BY index").ToList();
 
                stopwatch.Stop();
                Console.WriteLine(i);
                Console.WriteLine(avgExeTime);
                Console.WriteLine(stopwatch.ElapsedMilliseconds );
                avgExeTime += (stopwatch.ElapsedMilliseconds / 1000.0);
                Console.WriteLine(avgExeTime);
                 i = 1;
            
                stopwatch.Start();
                  _postgresqlDb.HealthCares_1.FromSqlRaw(@$"SELECT * FROM health_cares_{i} 
                WHERE 
                    bmi = (SELECT CAST(bmiValue as double precision) FROM (SELECT ROUND(avgBmi::numeric,0) as bmiValue FROM(SELECT AVG(bmi) as avgBmi FROM health_cares_{i}  ) as bmiTable) as bmiT) AND 
                    physical_health = (SELECT ROUND(avgPhy::numeric,0) FROM(SELECT AVG(physical_health) as avgPhy FROM health_cares_{i}  ) as avgPhyT) AND 
                    mental_health = (SELECT ROUND(avgMental::numeric,0) FROM(SELECT AVG(mental_health) as avgMental FROM health_cares_{i}  ) as avgMentalT) AND 
                    sleep_time = (SELECT ROUND(avgSleep::numeric,0) as avgRoundSleep FROM (SELECT gen_health, AVG(sleep_time) as avgSleep FROM health_cares_{i}   GROUP BY gen_health) as T WHERE T.gen_health='Very good') 
                ORDER BY index").ToList();
 
                stopwatch.Stop();
                Console.WriteLine(i);
                Console.WriteLine(avgExeTime);
                Console.WriteLine(stopwatch.ElapsedMilliseconds );
                avgExeTime += (stopwatch.ElapsedMilliseconds / 1000.0);
                Console.WriteLine(avgExeTime);
                
                i = 2;
            
                stopwatch.Start();
               _postgresqlDb.HealthCares_2.FromSqlRaw(@$"SELECT * FROM health_cares_{i} 
                WHERE 
                    bmi = (SELECT CAST(bmiValue as double precision) FROM (SELECT ROUND(avgBmi::numeric,0) as bmiValue FROM(SELECT AVG(bmi) as avgBmi FROM health_cares_{i}  ) as bmiTable) as bmiT) AND 
                    physical_health = (SELECT ROUND(avgPhy::numeric,0) FROM(SELECT AVG(physical_health) as avgPhy FROM health_cares_{i}  ) as avgPhyT) AND 
                    mental_health = (SELECT ROUND(avgMental::numeric,0) FROM(SELECT AVG(mental_health) as avgMental FROM health_cares_{i}  ) as avgMentalT) AND 
                    sleep_time = (SELECT ROUND(avgSleep::numeric,0) as avgRoundSleep FROM (SELECT gen_health, AVG(sleep_time) as avgSleep FROM health_cares_{i}   GROUP BY gen_health) as T WHERE T.gen_health='Very good') 
                ORDER BY index").ToList();
 
                stopwatch.Stop();
                Console.WriteLine(i);
                Console.WriteLine(avgExeTime);
                Console.WriteLine(stopwatch.ElapsedMilliseconds );
                avgExeTime += (stopwatch.ElapsedMilliseconds / 1000.0);
                Console.WriteLine(avgExeTime);
                
                i = 3;
            
                stopwatch.Start();
                 _postgresqlDb.HealthCares_3.FromSqlRaw(@$"SELECT * FROM health_cares_{i} 
                WHERE 
                    bmi = (SELECT CAST(bmiValue as double precision) FROM (SELECT ROUND(avgBmi::numeric,0) as bmiValue FROM(SELECT AVG(bmi) as avgBmi FROM health_cares_{i}  ) as bmiTable) as bmiT) AND 
                    physical_health = (SELECT ROUND(avgPhy::numeric,0) FROM(SELECT AVG(physical_health) as avgPhy FROM health_cares_{i}  ) as avgPhyT) AND 
                    mental_health = (SELECT ROUND(avgMental::numeric,0) FROM(SELECT AVG(mental_health) as avgMental FROM health_cares_{i}  ) as avgMentalT) AND 
                    sleep_time = (SELECT ROUND(avgSleep::numeric,0) as avgRoundSleep FROM (SELECT gen_health, AVG(sleep_time) as avgSleep FROM health_cares_{i}   GROUP BY gen_health) as T WHERE T.gen_health='Very good') 
                ORDER BY index").ToList();
 
                stopwatch.Stop();
                Console.WriteLine(i);
                Console.WriteLine(avgExeTime);
                Console.WriteLine(stopwatch.ElapsedMilliseconds );
                avgExeTime += (stopwatch.ElapsedMilliseconds / 1000.0);
                Console.WriteLine(avgExeTime);

            
                i = 4;
            
                stopwatch.Start();
                serviceModel.Payload.Records =  _postgresqlDb.HealthCares_4.FromSqlRaw(@$"SELECT * FROM health_cares_{i} 
                WHERE 
                    bmi = (SELECT CAST(bmiValue as double precision) FROM (SELECT ROUND(avgBmi::numeric,0) as bmiValue FROM(SELECT AVG(bmi) as avgBmi FROM health_cares_{i}  ) as bmiTable) as bmiT) AND 
                    physical_health = (SELECT ROUND(avgPhy::numeric,0) FROM(SELECT AVG(physical_health) as avgPhy FROM health_cares_{i}  ) as avgPhyT) AND 
                    mental_health = (SELECT ROUND(avgMental::numeric,0) FROM(SELECT AVG(mental_health) as avgMental FROM health_cares_{i}  ) as avgMentalT) AND 
                    sleep_time = (SELECT ROUND(avgSleep::numeric,0) as avgRoundSleep FROM (SELECT gen_health, AVG(sleep_time) as avgSleep FROM health_cares_{i}   GROUP BY gen_health) as T WHERE T.gen_health='Very good') 
                ORDER BY index").ToList();
 
                stopwatch.Stop();
                Console.WriteLine(i);
                Console.WriteLine(avgExeTime);
                Console.WriteLine(stopwatch.ElapsedMilliseconds );
                avgExeTime += (stopwatch.ElapsedMilliseconds / 1000.0);
                Console.WriteLine(avgExeTime);
                
            avgExeTime = avgExeTime / 5.0;
            serviceModel.Payload.ExecuteTime = avgExeTime;
            serviceModel.StatusCodes = StatusCodes.Status200OK;
            return serviceModel;
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            Console.WriteLine(e);
            serviceModel.Payload.Records =null;
            serviceModel.Payload.ExecuteTime = 0;
            serviceModel.StatusCodes = StatusCodes.Status400BadRequest;
            return serviceModel;
        }
    }

}