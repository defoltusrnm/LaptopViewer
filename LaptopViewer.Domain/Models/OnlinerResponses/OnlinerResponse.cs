namespace LaptopViewer.Domain.Models.OnlinerResponses;

public class OnlinerResponse
{
    public required ICollection<ProductResponse> Products { get; init; }
}