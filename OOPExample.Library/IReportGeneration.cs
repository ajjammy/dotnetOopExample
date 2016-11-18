using System;

namespace OOPExample.Library
{
    public class IReportGeneration
    {
        public virtual bool GenerateReport(Employee em)
        {
            Console.WriteLine("From base.");

            return true;
        }
    }
}
