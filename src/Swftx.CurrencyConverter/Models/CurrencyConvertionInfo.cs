using System.Text.Json.Serialization;

namespace Swftx.CurrencyConverter.Models
{
    public class CurrencyConvertionInfo
    {
        [JsonPropertyName("rate")]
        public decimal Rate { get; init; }
    }
}
