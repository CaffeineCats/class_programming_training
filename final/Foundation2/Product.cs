public class Product
{
    private string _productId;
    private string _productName;
    private double _productUnitPrice;
    private int _productQuantity;

    public Product(string id, string name, double unitPrice, int quantity)
    {
        _productId = id;
        _productName = name;
        _productUnitPrice = unitPrice;
        _productQuantity = quantity;
    }

    public string GetProductLabel()
    {
        return $"ID:{_productId} Name:{_productName}";
    }
    
    public double GetProductTotalCost()
    {
        return Math.Round(_productUnitPrice * _productQuantity, 2, MidpointRounding.AwayFromZero);
    }

}