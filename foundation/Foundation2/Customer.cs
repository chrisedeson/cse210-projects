public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // Method to check if customer is in the USA
    public bool IsCustomerUSA()
    {
        return _customerAddress.IsAddressUSA(); // Use the field directly
    }

    // Getter for customer name
    public string GetName()
    {
        return _customerName;
    }

    // Getter for customer address as a string
    public string GetAddress()
    {
        return _customerAddress.GetAddress();
    }
}
