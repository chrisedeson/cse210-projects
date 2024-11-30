using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address customerAddress = new Address(
            "123 Maple Street", 
            "Springfield", 
            "IL", 
            "USA"
        );

        // Create a customer
        Customer customer = new Customer("John Doe", customerAddress);

        // Create some products
        Product product1 = new Product("Laptop", "A123", 1200.50, 1);
        Product product2 = new Product("Mouse", "B456", 25.99, 2);
        Product product3 = new Product("Keyboard", "C789", 75.49, 1);

        // Create an order for the customer
        Order order = new Order(customer);

        // Add products to the order
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        // Order 2: Christopher Effiong in Lagos, Nigeria
        Address address2 = new Address("12 Marina Road", "Lagos", "Lagos State", "Nigeria");
        Customer customer2 = new Customer("Christopher Effiong", address2);
        Product product4 = new Product("Smartphone", "D001", 450.75, 1);
        Product product5 = new Product("Earphones", "D002", 15.99, 3);
        Product product6 = new Product("Power Bank", "D003", 35.49, 2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        DisplayOrder(order2);


        // Display the packing label
        Console.WriteLine(order.GetPackingLabel());

        // Display the shipping label
        Console.WriteLine(order.GetShippingLabel());

        // total cost
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");

        static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine("-----------------------------------");
    }
    
    }
}