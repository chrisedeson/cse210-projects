public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost of the product
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return _productName;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return _productId;
    }
}
