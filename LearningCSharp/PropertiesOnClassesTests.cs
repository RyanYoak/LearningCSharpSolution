using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class PropertiesOnClassesTests
    {
        [Fact]
        public void UsingProperties()
        {
            var cust = new Customer()
            {
                FirstName = "Joe",
                LastName = "Shmo"
            };
            Assert.Equal("Joe", cust.FirstName);
            Assert.Equal("Shmo", cust.LastName);
        }
    }

    public class Customer
    {
        // state & behavior (data, code)
        private string _firstName; // "Backing Field"
        public string FirstName // "Property"
        {
            get { return FirstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; } // Same as all above, but the compiler does it for you

        public decimal CreditLimit { get; private set; } = 5000;
    }
}
