using NUnit.Framework;
using OOPExample.Library;

namespace OOPExample.Test
{
    [TestFixture]
    public class EmployeeTest
    {
        private Employee employee;

        [SetUp]
        public void Setup() {
           
        }
        
        [Test]
        public void CreateEmployee()
        {
            employee = new Employee
            {
                Id = 1,
                FirstName = "Nadat",
                LastName = "Kukimiya"
            };

            Assert.NotNull(employee);
        }
    }
}
