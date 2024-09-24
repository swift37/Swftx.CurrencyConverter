using Swftx.CurrencyConverter.Models;
using System.Net.Http.Json;

namespace Swftx.CurrencyConverter;

public class CurrecyCoverterClient
{
    private const string BASE_URI = "https://api.fxratesapi.com";

    private readonly HttpClient _client;

    public CurrecyCoverterClient(HttpClient client)
    {
        client.BaseAddress = new Uri(BASE_URI);
        _client = client;
    }

    public async Task<CurrencyRatesResponse?> GetLatestRatesByEUR(CancellationToken cancellation = default)
    {
        return await _client
            .GetFromJsonAsync<CurrencyRatesResponse>($"/latest?base=USD&format=json")
            .ConfigureAwait(false);
    }

    public async Task<CurrencyRatesResponse?> GetLatestRates(string baseCurrency, CancellationToken cancellation = default)
    {
        return await _client
            .GetFromJsonAsync<CurrencyRatesResponse>($"/latest?base={baseCurrency}&format=json")
            .ConfigureAwait(false);
    }

    public async Task<CurrencyRatesResponse?> GetLatestRates(string baseCurrency, string[] symbols, CancellationToken cancellation = default)
    {
        var symbolsStr = string.Join(",", symbols);

        return await _client
            .GetFromJsonAsync<CurrencyRatesResponse>($"/latest?base={baseCurrency}&symbols={symbolsStr}&format=json")
            .ConfigureAwait(false);
    }

    public async Task<CurrencyConvertionResponse?> Covert(string fromCurrency, string toCurrency, decimal amount, CancellationToken cancellation = default)
    {
        return await _client
            .GetFromJsonAsync<CurrencyConvertionResponse>($"/convert?from={fromCurrency}&to={toCurrency}&amount={}&format=json")
            .ConfigureAwait(false);
    }
}
