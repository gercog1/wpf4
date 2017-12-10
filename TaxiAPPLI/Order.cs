using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TaxiAPPLI
{
    public class Order
    {
        public string PhoneNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Type { get; set; }
        public double _price;
        public double Price {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                    throw new ArgumentException("Value should be equal to 0 or greater than 0!");
            }
        }

        public Order( string ph, string f, string t, double p, string typ)
        {
            PhoneNumber = ph;
            From = f;
            To = t;
            Price = p;
            Type = typ;
        }

        public static void WriteToFile(string path, Order order)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            { 
                    writer.WriteLine(order);      
            }
        }

        public override string ToString()
        {
            return PhoneNumber + " " + From+ " " + To + " " + Type + " " + Price;
        }

    }
}
