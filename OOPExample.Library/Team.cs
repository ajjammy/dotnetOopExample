
using System.Collections.Generic;

namespace OOPExample.Library
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; private set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            this.Employees.Remove(employee);
        }
    }
}
