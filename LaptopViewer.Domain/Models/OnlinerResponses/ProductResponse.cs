using System.Text.Json.Serialization;

namespace LaptopViewer.Domain.Models.OnlinerResponses;

public class ProductResponse
{
    public required string Name { get; init; }
    
    public required string Description { get; init; }

    [JsonPropertyName("images")] public ImageResponse? Image { get; init; }
    
    public ProductPriceResponse? Prices { get; init; }
}