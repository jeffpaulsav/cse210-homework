using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _country;
        private string _state;

        public Address(string streetAddress, string city, string country, string state)
        {
            _city = city;
            _country = country;
            _streetAddress = streetAddress;
            _state = state;
        }

        // gives value for check of inside or out of USA
        public bool InUSA()
        {
            if (_country == "USA")
                return true;
            else
                return false;
        }

        // calls for a returned string of the address
        public string GetFullAddress()
        {
            string addressString = _streetAddress + " " + _city + " "+ _country;
            return addressString;
        }

        // just prints full address
        public void DisplayFullAddress()
        {
            Console.WriteLine($"{_streetAddress}, {_city}, {_state} ");
        }
    }
}
