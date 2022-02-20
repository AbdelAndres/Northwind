using System;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.Common;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.CustomersBrl;

namespace ConsoleAppCustomers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer()
            {
                CustomerID = "CRICK",
                CompanyName = "Cricket Kompanyon Host"
                
            };
            CustomerBrl.Insert(customer);
        }
    }
}
