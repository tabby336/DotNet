using System.Collections.Generic;
using System;
using Company;
using Xunit;

namespace TestApp
{
    public class EmployeeRepositoryTests
    {
        [Fact]
        public void When_EmployeeRepositoryIsInstanciatedCorrectly_Then_IsShouldHaveEnoughEmployees()
        {
            EmployeeRepository emps = CreateSutCorrectly();
            Assert.Equal(emps.Employees.Count, 10);
        }

        [Fact]
        public void When_EmployeeRepositoryIsInstanciatedIncorrectly_Then_IsShouldThrowException() 
        {
            EmployeeRepository emps;
            Exception e = Assert.Throws<ArgumentException>(() => emps = CreateSutIncorrectly());
            Assert.Equal("Can't make a company with so few employees", e.Message);
            //Assert.StartsWith("Can't make a company with so few employees", e.Message);
            //Assert.Equal("Can't make a company with so few employees".CompareTo(e.Message), 0);
            
        }

        [Fact]
        public void When_RetrieveArchitectsIsCalled_Then_ItShouldReturnAListOfCount5()
        {
            EmployeeRepository emps = CreateSutCorrectly();
            IEnumerable<Architect> architects = emps.RetriveArchitects();
            Assert.Equal(IEnumerable_Count(architects), 5);
        }

        [Fact]
        public void When_RetrieveManagersIsCalled_Then_ItShouldReturnAListOfCount5()
        {
            EmployeeRepository emps = CreateSutCorrectly();
            IEnumerable<Manager> managers = emps.RetriveManagers();
            Assert.Equal(IEnumerable_Count(managers), 5);
        }


        [Fact]
        public void When_RetriveActiveEmployees_Then_ItShouldReturnAListOfCount8()
        {
            EmployeeRepository emps = CreateSutCorrectly();
            IEnumerable<Employee> activeEmps = emps.RetriveActiveEmployees();
            Assert.Equal(IEnumerable_Count(activeEmps), 8);
        }

        [Fact]
        public void When_RetrieveAllIsCalledWithString_Then_ItShouldReturnA1Employee()
        {
            EmployeeRepository emps = CreateSutCorrectly();
            IEnumerable<Employee> contrainingStr = emps.RetriveAll("10");
            Assert.Equal(IEnumerable_Count(contrainingStr), 1);
        }

        [Fact]
        public void When_RetriveAllOrderBySalaryAscendingIsCalled_Then_TheResultShouldMatchTheSalaryArray() 
        {
            EmployeeRepository emps = CreateSutCorrectly();
            List<int> salaries = CreateSalarySut();
            IEnumerable<Employee> salaryOrdered = emps.RetriveAllOrderBySalaryAscending();
            int count = 0;
            foreach(var emp in salaryOrdered) 
            {
                count += 1;
                Assert.Equal(emp.Salary, salaries[count-1]);
            } 
        }

        [Fact]
        public void When_RetriveAllOrderBySalaryDescendingIsCalled_Then_TheResultShouldMatchTheSalaryArrayReversed() 
        {
            EmployeeRepository emps = CreateSutCorrectly();
            List<int> salaries = CreateSalarySut();
            IEnumerable<Employee> salaryOrdered = emps.RetriveAllOrderBySalaryDescending();
            int count = 0;
            foreach(var emp in salaryOrdered)
            {
                count += 1;
                Assert.Equal(emp.Salary, salaries[10 - count]);
            }
        }
        
        private static int IEnumerable_Count(IEnumerable<Employee> emps)
        {
            int count = 0;
            foreach(var emp in emps)
            {
                count += 1;
            }
            return count;
        }

        [Fact]
        public void When_RetrieveAllisCalledWithDates_Then_ItShouldReturn1Employee() 
        {
            EmployeeRepository emps = CreateSutCorrectly();
            List<Employee> empsList = emps.RetriveAll(new DateTime(1996, 1, 1, 0, 0, 0), DateTime.Now);
            Assert.Equal(empsList.Count, 1);
            Assert.Equal(empsList[0].GetFullName(), "Ioana1 manager1");

        }

        private static EmployeeRepository CreateSutCorrectly()
        {
            List<Employee> emps = new List<Employee>();
            
            Manager two = new Manager(Guid.NewGuid(), "Ioana1", "manager1", new DateTime(1996, 5, 2,0 ,0 ,0), 1);
            two.QuitMyJob(DateTime.Now.AddDays(-1));
            emps.Add(two);

            emps.Add(new Manager(Guid.NewGuid(), "Ioana2", "manager2", new DateTime(1995, 5, 2,0 ,0 ,0), 10));
            emps.Add(new Manager(Guid.NewGuid(), "Ioana3", "manager3", new DateTime(1995, 5, 2,0 ,0 ,0), 100));
            emps.Add(new Manager(Guid.NewGuid(), "Ioana4", "manager4", new DateTime(1995, 5, 2,0 ,0 ,0), 1000));
            emps.Add(new Manager(Guid.NewGuid(), "Ioana5", "manager5", new DateTime(1995, 5, 2,0 ,0 ,0), 10000));

            emps.Add(new Architect(Guid.NewGuid(), "Ioana6", "architect0", new DateTime(1995, 5, 2,0 ,0 ,0), 2));
            emps.Add(new Architect(Guid.NewGuid(), "Ioana7", "architect1", new DateTime(1995, 5, 2,0 ,0 ,0), 20));
            
            Architect one = new Architect(Guid.NewGuid(), "Ioana8", "architect2", new DateTime(1995, 5, 2,0 ,0 ,0), 200);
            one.QuitMyJob(DateTime.Now.AddDays(-2));
            emps.Add(one);
            
            emps.Add(new Architect(Guid.NewGuid(), "Ioana9", "architect3", new DateTime(1995, 5, 2,0 ,0 ,0), 2000));
            Architect three = new Architect(Guid.NewGuid(), "Ioana10", "architect4", new DateTime(1995, 5, 2,0 ,0 ,0), 20000);
            three.QuitMyJob(DateTime.Now.AddDays(4));
            emps.Add(three);

            return new EmployeeRepository(emps);
        }

        private static EmployeeRepository CreateSutIncorrectly() 
        {
            List<Employee> emps = new List<Employee>();
            return new EmployeeRepository(emps);
        }

        private static List<int> CreateSalarySut() 
        {
            List<int> salaries = new List<int>{1,2,10,20,100,200,1000,2000,10000,20000};
            return salaries;
        }
    }
}
