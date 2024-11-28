using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");


            Customer customer1 = new Customer( address1 ,"Moroni Bamvakiades Ramos");
            Customer customer2 = new Customer( address2,"Jarede Bamvakiades Ramos");

     
            Product product1 = new Product("Laptop", "A100", 799.99m, 1);
            Product product2 = new Product("Mouse", "B200", 25.99m, 2);
            Product product3 = new Product("Keyboard", "C300", 49.99m, 1);
            Product product4 = new Product("Monitor", "D400", 199.99m, 1);

  
            Order order1 = new Order(customer1);
            order1.AddProductToOrder(product1);
            order1.AddProductToOrder(product2);

            Order order2 = new Order(customer2);
            order2.AddProductToOrder(product3);
            order2.AddProductToOrder(product4);

  
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()} USD");
            Console.WriteLine();

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()} USD");
        }
    }
}
