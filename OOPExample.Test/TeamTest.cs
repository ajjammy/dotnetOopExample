using NUnit.Framework;
using OOPExample.Library;

namespace OOPExample.Test
{
    [TestFixture]
    public class TeamTest
    {
        private Team team;
        private Employee employee;
  
        [SetUp]
        public void Setup() {
            team = new Team { Id = 1, Name = "New Team" };
            employee = new Employee { Id = 1, FirstName = "Jammy", LastName = "Inta" };
        }
        
        [Test]
        public void CreateTeam()
        {
            Assert.NotNull(team);
        }

        [Test]
        public void AddEmployeeToTeam()
        {
            int beforeAdd = team.Employees.Count;

            team.AddEmployee(employee);

            Assert.AreEqual((beforeAdd + 1), team.Employees.Count);
        }

        [Test]
        public void RemoveEmployeeFromTeam()
        {
            team.AddEmployee(employee);
            int beforeRemove = team.Employees.Count;
            
            team.RemoveEmployee(employee);
            Assert.AreEqual((beforeRemove - 1), team.Employees.Count);
        }
    }
}
