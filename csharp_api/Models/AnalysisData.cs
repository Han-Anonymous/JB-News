using System.Text.Json.Serialization;

namespace JBSnorro;
public class AnalysisData
{
    [JsonPropertyName("Actual > Forecast > Previous")]
    public string? ActualMoreThanForecastMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Forecast < Previous")]
    public string? ActualMoreThanForecastLessThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Actual < Previous")]
    public string? ActualMoreThanForecastAndActualLessThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Forecast = Previous")]
    public string? ActualMoreThanForecastEqualToPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Actual = Previous")]
    public string? ActualMoreThanForecastAndActualEqualToPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast < Previous")]
    public string? ActualLessThanForecastAndPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Forecast > Previous")]
    public string? ActualLessThanForecastMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Actual > Previous")]
    public string? ActualLessThanForecastAndActualMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Actual = Previous")]
    public string? ActualLessThanForecastAndActualEqualToPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast = Previous")]
    public string? ActualLessThanForecastEqualToPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast = Previous")]
    public string? ActualEqualToForecastAndPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast < Previous")]
    public string? ActualEqualToForecastLessThanPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast > Previous")]
    public string? ActualEqualToForecastMoreThanPrevious { get; set; }
}
