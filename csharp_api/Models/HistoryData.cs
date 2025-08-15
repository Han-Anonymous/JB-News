using System.Text.Json.Serialization;

namespace JBSnorro;
public class HistoryData
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("Actual")]
    public double Actual { get; set; }

    [JsonPropertyName("Forecast")]
    public double Forecast { get; set; }

    [JsonPropertyName("Previous")]
    public double Previous { get; set; }

    [JsonPropertyName("Outcome")]
    public string? Outcome { get; set; }
}
