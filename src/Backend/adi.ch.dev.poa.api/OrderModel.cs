namespace adi.ch.dev.poa.api;

public class OrderModel
{
    public DateTime OrderDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string? Details { get; set; }
}
