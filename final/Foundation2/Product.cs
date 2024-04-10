using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Product
    {
        private string _name;
        private string _productID;
        private double _price;
        private int _quantity;

        public Product(string name, string productID, double price, int quantity) 
        {
            _name = name;
            _productID = productID;
            _price = price;
            _quantity = quantity;
        }

        // calculate cost based on price and quantity of product
        public double Cost() 
        {
            double monetarycost = (_price * _quantity);
            return monetarycost;
        }

        // give product summary
        public string ProductSummary()
        {
            string summaryProduct = $"{_name} : {_productID} ";
            return summaryProduct;
        }

    }
}
