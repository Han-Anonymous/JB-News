using System.Text.Json.Serialization;

namespace JBSnorro;

public class MachineLearningData
{
    [JsonPropertyName("Outcomes")]
    public MLData? Outcomes { get; set; }
}

public class MLData
{
    [JsonPropertyName("Actual > Forecast > Previous")]
    public MLOutcomes? ActualMoreThanForecastMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Forecast < Previous")]
    public MLOutcomes? ActualMoreThanForecastLessThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Actual < Previous")]
    public MLOutcomes? ActualMoreThanForecastAndActualLessThanPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Forecast = Previous")]
    public MLOutcomes? ActualMoreThanForecastEqualToPrevious { get; set; }

    [JsonPropertyName("Actual > Forecast Actual = Previous")]
    public MLOutcomes? ActualMoreThanForecastAndActualEqualToPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast < Previous")]
    public MLOutcomes? ActualLessThanForecastAndPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Forecast > Previous")]
    public MLOutcomes? ActualLessThanForecastMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Actual > Previous")]
    public MLOutcomes? ActualLessThanForecastAndActualMoreThanPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast Actual = Previous")]
    public MLOutcomes? ActualLessThanForecastAndActualEqualToPrevious { get; set; }

    [JsonPropertyName("Actual < Forecast = Previous")]
    public MLOutcomes? ActualLessThanForecastEqualToPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast = Previous")]
    public MLOutcomes? ActualEqualToForecastAndPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast < Previous")]
    public MLOutcomes? ActualEqualToForecastLessThanPrevious { get; set; }

    [JsonPropertyName("Actual = Forecast > Previous")]
    public MLOutcomes? ActualEqualToForecastMoreThanPrevious { get; set; }
}

public class MLOutcomes
{
    [JsonPropertyName("1 Hour")]
    public MLTimeframe? OneHour { get; set; }

    [JsonPropertyName("1 Minute")]
    public MLTimeframe? OneMinute { get; set; }

    [JsonPropertyName("30 Minute")]
    public MLTimeframe? ThirtyMinute { get; set; }
}

public class MLTimeframe
{
    [JsonPropertyName("Bearish")]
    public double Bearish { get; set; }

    [JsonPropertyName("Bullish")]
    public double Bullish { get; set; }
}
