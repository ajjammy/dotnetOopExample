using OOPExample.Library;
using NUnit.Framework;

namespace OOPExample.Test
{
    [TestFixture]
    public class PDFReportGeneraionTest
    {
        private IReportGeneration reportGeneration;
        private Employee employee;
        [SetUp]
        public void Setup()
        {
            reportGeneration = new PDFReportGeneraion();
            employee = new Employee { Id = 1, FirstName = "Jammy", LastName = "Inta" };
        }

        [Test]
        public void CanGeneratePDFReport()
        {
            Assert.True(reportGeneration.GenerateReport(employee));
        }
    }
}
