using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace JBSnorro;

public class NewsData
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("Event_ID")]
    public int EventId { get; set; }

    [JsonPropertyName("SmartAnalysis")]
    public AnalysisData? SmartAnalysis { get; set; }

    [JsonPropertyName("History")]
    public List<HistoryData>? History { get; set; }

    [JsonPropertyName("MachineLearning")]
    public MachineLearningData? MachineLearning { get; set; }
}
