using System.Text.Json.Serialization;

namespace Swftx.CurrencyConverter.Models
{
    public class CurrencyRatesResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; init; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; init; }

        [JsonPropertyName("base")]
        public required string BaseCurrency { get; init; }

        [JsonPropertyName("date")]
        public DateTime Date { get; init; }

        [JsonPropertyName("rates")]
        public IDictionary<string, decimal> Rates { get; init; } = new Dictionary<string, decimal>();
    }
}
