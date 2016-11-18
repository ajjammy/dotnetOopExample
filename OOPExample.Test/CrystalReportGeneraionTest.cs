using OOPExample.Library;
using NUnit.Framework;

namespace OOPExample.Test
{
    [TestFixture]
    public class CrystalReportGeneraionTest
    {
        private IReportGeneration reportGeneration;
        private Employee employee;
        [SetUp]
        public void Setup()
        {
            reportGeneration = new CrystalReportGeneraion();
            employee = new Employee { Id = 1, FirstName = "Jammy", LastName = "Inta" };
        }

        [Test]
        public void CanGenerateCrystalReport()
        {
            Assert.True(reportGeneration.GenerateReport(employee));
        }
    }
}
