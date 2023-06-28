using System.Text.Json.Serialization;

namespace LaptopViewer.Domain.Models.OnlinerResponses;

public class ImageResponse
{
    public required string Header { get; init; }
    
    public required object Icon { get; init; }

    public string Url => $"https:{Header}";
}