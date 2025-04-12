using System;

class Program
{
    static void Main(string[] args)
    {
        //Addresses
        Address address1 = new Address("Rua Duque de Caxias 708", "Livramento", "RS", "Brazil");
        Address address2 = new Address("456 Time Square", "New York", "NY", "USA");

        //Customers
        Customer customer1 = new Customer("João Silva", address1);
        Customer customer2 = new Customer("John Smith", address2);

        //Products
        Product product1 = new Product("Wireless Controller", "WC007", 25.99, 2);
        Product product2 = new Product("Mechanical Keyboard", "KBM015", 45.50, 1);
        Product product3 = new Product("USB-C Cable", "UC033", 9.99, 3);
        Product product4 = new Product("Laptop Cooler", "LC008", 322.75, 1);

        //Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}
