using System.Text.Json.Serialization;

namespace LaptopViewer.Domain.Models.OnlinerResponses;

public class ProductPriceResponse
{
    [JsonPropertyName("price_min")]
    public Price? MinPrice { get; init; }

    public class Price
    {
        [JsonPropertyName("amount")] public string Amount { get; init; } = "0";
    }
}