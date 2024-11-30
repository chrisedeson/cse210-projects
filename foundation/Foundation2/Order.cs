public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalCost(); // Fixed typo
        }

        // Add shipping cost
        double shippingCost = _customer.IsCustomerUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n"; // Display product name and ID
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress();
        return label;
    }
}
