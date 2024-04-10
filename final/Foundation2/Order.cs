using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Order
    {
        private int _international = 35;
        private int _national = 5;
        private double _checkoutPrice;
        List<Product> _products = new List<Product>();
        Address _address;
        Customer _customer;

        public Order(Address address, Customer customer) 
        {
            _address = address;
            _customer = customer;
        }

        // add product to products list inside Order
        public void AddProduct(Product product) 
        {
            _products.Add(product);
        }

        // total price is calculated as the sum of the total cost of each product plus a one-time shipping cost
        public double CalculateOrderPrice(bool check) 
        {
            if (check == true)
            {
                foreach (Product product in _products)
                { _checkoutPrice += product.Cost() + _national; }
            }
            else
            {   
                foreach (Product product in _products) 
                { _checkoutPrice += product.Cost() + _international; } 
            }
            return _checkoutPrice;
        }

        public void DisplayOrderPrice()
        {
            var price = CalculateOrderPrice(_address.InUSA());
            Console.WriteLine();
            Console.WriteLine($"Order Total Price: ${price} ");
        }

        // packing label should list the name and product id of each product in the order
        public void GetPackingLabel() 
        {
            foreach (Product product in _products)
            {
                Console.WriteLine();
                Console.WriteLine($"Packing Label: {product.ProductSummary()} ");
            }
        }

        // shipping label should list the name and address of the customer
        public void GetShippingLabel() 
        {
            Console.WriteLine();
            Console.WriteLine($"Shipping Label: {_customer.GetCustomerName()} : {_address.GetFullAddress()} ");
        }

    }
}
