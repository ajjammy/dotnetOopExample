using System;

namespace OOPExample.Library
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DisplayEmployee()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("First Name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
        }
    }
}
