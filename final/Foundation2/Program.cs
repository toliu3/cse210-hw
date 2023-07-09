using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> product1s = new List<Product>();
        Address address1 = new Address("32 W 5030 S", "Salt Lake City", "UT 84129", "USA");
        Customer customer1 = new Customer("Jane Smith", address1);
        Product p1 = new Product("iPhone 12", "IPH12", 999.99, 1);
        Product p2 = new Product("Samsung Galaxy S21", "SGS21", 899.99, 1);
        Product p3 = new Product("Sony WH-1000XM4 Headphones", "SONYXM4", 349.99, 2);
        product1s.Add(p1);
        product1s.Add(p2);
        product1s.Add(p3);

        Order order1 = new Order(product1s, customer1);
        Console.WriteLine("Order 1");
        Console.WriteLine("-------");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.TotalPrice()+"\n");
        Console.WriteLine("===========================================================================");

        List<Product> product2s = new List<Product>();
        Address address2 = new Address("No.298, Siwei St.", "Guanmiao Dist.", "Tainan City", "Taiwan");
        Customer customer2 = new Customer("Joseph Liu", address2);
        Product p21 = new Product("Widget", "W123", 19.99, 2); 
        Product p22 = new Product("Gadget", "G456", 14.99, 3);
        Product p23 = new Product("Accessory", "A789", 9.99, 1);
        product2s.Add(p21);
        product2s.Add(p22);
        product2s.Add(p23);

        Order order2 = new Order(product2s, customer2);
        Console.WriteLine("Order 2");
        Console.WriteLine("-------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.TotalPrice()+"\n");
        
    }
}