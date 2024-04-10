using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Customer
    {
        private string _customerName;

        public Customer(string customerName, Address customerAddress) 
        {
            _customerName = customerName;
        }

        // getter for customer name
        public string GetCustomerName()
        {
            return _customerName;
        }

    }
}
