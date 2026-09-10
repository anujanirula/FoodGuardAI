namespace FoodGuardAI.Web.Models;

public class FoodAnalysisResult
{
    public string FoodType { get; set; } = string.Empty;
    public string RiskLevel { get; set; } = string.Empty;
    public string Recommendation { get; set; } = string.Empty;
    public double Confidence { get; set; }
}