using OOPExample.Library;
using System;

namespace OOPExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class, Field, Method
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Nadat",
                LastName = "Kukimiya"
            };

            employee.DisplayEmployee();
            Console.WriteLine();


            //Interface, Inheritance, Override
            IReportGeneration reportGeneration = new PDFReportGeneraion();
            reportGeneration.GenerateReport(employee);

            reportGeneration = new CrystalReportGeneraion();
            reportGeneration.GenerateReport(employee);

            Console.ReadLine();
        }
    }
}
