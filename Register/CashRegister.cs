using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class CashRegister
    {
        // One function: Takes a list of products and
        // calculates the grand total price

        public static decimal GrandTotal(List<Product> prods)
        {
            decimal total = 0m;
            foreach (Product prod in prods)
            {
                total += prod.Price;
            }
            return total;
        }


        // Second function (practice): Takes a list of products
        // and calculates the sales tax (say 6% or 0.06)
        public static decimal CalculateTax(List<Product> prods)
        {
            decimal total = 0m;
            foreach (Product prod in prods)
            {
                total += prod.Price;
            }
            
            return 0.06m * total; 
        }
    }
}
