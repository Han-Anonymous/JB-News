using System.Text.Json.Serialization;

namespace JBSnorro;

public class NewsInfo
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("Event_ID")]
    public int EventId { get; set; }
}
