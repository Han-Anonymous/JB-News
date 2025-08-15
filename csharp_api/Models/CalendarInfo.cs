using System;
using System.Text.Json.Serialization;

namespace JBSnorro;

public class CalendarInfo
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("Event_ID")]
    public int EventId { get; set; }

    [JsonPropertyName("Category")]
    public string? Category { get; set; }

    [JsonPropertyName("Date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("Actual")]
    public double Actual { get; set; }

    [JsonPropertyName("Forecast")]
    public double Forecast { get; set; }

    [JsonPropertyName("Previous")]
    public double Previous { get; set; }

    [JsonPropertyName("Outcome")]
    public string? Outcome { get; set; }

    [JsonPropertyName("Strength")]
    public string? Strength { get; set; }

    [JsonPropertyName("Quality")]
    public string? Quality { get; set; }

    [JsonPropertyName("Projection")]
    public string? Projection { get; set; }
}
