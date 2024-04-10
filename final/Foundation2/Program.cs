using Foundation2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // order 1
        Address address1 = new Address("4518 Hollowwberry Ct.", "Frederick", "USA", "Colorado");
        Customer customer1 = new Customer("Jefferson Savage", address1);

        Order order1 = new Order(address1, customer1);

        Product product1 = new Product("Xbox", "23411", 300, 2);
        order1.AddProduct(product1);

        order1.GetShippingLabel();
        order1.GetPackingLabel();
        order1.DisplayOrderPrice();


        // order 2 
        Address address2 = new Address("141 S 1st W", "Rexburg", "USA", "Idaho");
        Customer customer2 = new Customer("Hunter Demerly", address2);

        Order order2 = new Order(address2, customer2);

        Product product2 = new Product("Playstation 5", "54688", 400, 3);
        order2.AddProduct(product2);

        order2.GetShippingLabel();
        order2.GetPackingLabel();
        order2.DisplayOrderPrice(); 




    }
}