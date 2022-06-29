using System.ComponentModel.DataAnnotations;

namespace dotnet6_csharp_benchmark.Models;

public class HealthCare_3
{
    [Key]
    public string Id { get; set; }
    public long Index { get; set; }
    public bool HeartDisease { get; set; }
    public int Bmi { get; set; }
    public bool Smoking { get; set; }
    public bool Alcoholdrinking { get; set; }
    public bool Stroke { get; set; }
    public double PhysicalHealth { get; set; }
    public double MentalHealth { get; set; }
    public bool DiffWalking { get; set; }
    public string Sex { get; set; }
    public string AgeCategory { get; set; }
    public string Race { get; set; }
    public string Diabetic { get; set; }
    public bool PhysicalActivity { get; set; }
    public string GenHealth { get; set; }
    public double SleepTime { get; set; }
    public bool Asthma { get; set; }
    public bool KidneyDisease { get; set; }
    public bool SkinCancer { get; set; }
}