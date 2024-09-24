using System.Text.Json.Serialization;

namespace Swftx.CurrencyConverter.Models
{
    public class CurrencyConvertionResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; init; }

        [JsonPropertyName("info")]
        public required CurrencyConvertionInfo CurrencyConvertionInfo { get; init; }

        [JsonPropertyName("date")]
        public DateOnly Date { get; init; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; init; }

        [JsonPropertyName("result")]
        public decimal Result { get; init; }
    }
}
