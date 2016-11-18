using System;

namespace OOPExample.Library
{
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override bool GenerateReport(Employee em)
        {
            Console.WriteLine("Generate crystal report.");

            return true;
        }
    }
}
