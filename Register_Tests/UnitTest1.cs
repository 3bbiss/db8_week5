using Register;
using System.Diagnostics;
using System.Xml.Linq;

namespace Register_Tests
{
    public class UnitTest1
    {

        // Don't try to use [Theory]
        //Just make individual tests with [Fact]
        // Inside each test, create a list of Products, and
        // call the function 
        // and compare actual to expected

        [Fact]
        public void TestGrandTotal()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Milk", 2.5m));
            products.Add(new Product("Candy", 3.5m));
            products.Add(new Product("Cheese", 4.5m));
            products.Add(new Product("Soda", 5.5m));
            products.Add(new Product("Eggs", 6.5m));

            decimal actual = CashRegister.GrandTotal(products);
            decimal expected = 22.5m;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestCalculateTax()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Milk", 2.5m));
            products.Add(new Product("Candy", 3.5m));
            products.Add(new Product("Cheese", 4.5m));
            products.Add(new Product("Soda", 5.5m));
            products.Add(new Product("Eggs", 6.5m));

            decimal actual = CashRegister.CalculateTax(products);
            decimal expected = 1.35m;
            Assert.Equal(expected, actual);
            //Assert.Equal(1.35m, actual);
        }
    }
}
