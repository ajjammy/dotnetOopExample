using System;

namespace OOPExample.Library
{
    public class PDFReportGeneraion : IReportGeneration
    {
        public override bool GenerateReport(Employee em)
        {
            Console.WriteLine("Generate PDF report.");

            return true;
        }
    }

}
