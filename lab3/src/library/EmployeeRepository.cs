using System;
using System.Collections.Generic;
using System.Linq;

namespace Company 
{
    
    public class EmployeeRepository
    {
        public EmployeeRepository(List<Employee> emp) 
        {
            if(emp.Count < 10) 
            {
                throw new ArgumentException("Can't make a company with so few employees");
            }
            Employees = new List<Employee>(emp);
        }

        public IEnumerable<Architect> RetriveArchitects() 
        {
            IEnumerable<Architect> architects = from emp in Employees.OfType<Architect>() select emp;
            return (IEnumerable<Architect>) architects;
        }

        public IEnumerable<Manager> RetriveManagers()
        {
            IEnumerable<Employee> managers = from emp in Employees.OfType<Manager>() select emp;
            return (IEnumerable<Manager>) managers;
        }

        public IEnumerable<Employee> RetriveActiveEmployees()
        {
            IEnumerable<Employee> activeEmployees = from emp in Employees where emp.IsActive() select emp;
            return activeEmployees;
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryDescending()
        {
            IEnumerable<Employee> salaryOrder = from emp in Employees where true orderby emp.Salary descending select emp; 
            return salaryOrder;
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryAscending()
        {
            IEnumerable<Employee> salaryOrder = from emp in Employees where true orderby emp.Salary ascending select emp; 
            return salaryOrder;
        }

        public List<Employee> RetriveAll(string str)
        {
            List<Employee> foundEmp = new List<Employee>();
            foreach(Employee emp in Employees)
            {
                if(emp.LastName.Contains(str) || emp.FirstName.Contains(str)) 
                {
                    foundEmp.Add(emp);
                }
            }
            return foundEmp;
        }

        public List<Employee> RetriveAll(DateTime start, DateTime end)
        {
            List<Employee> foundEmp = new List<Employee>();
            foreach(Employee emp in Employees)
            {
                if(emp.StartDate > start && emp.StartDate < end)
                {
                    foundEmp.Add(emp);
                }
            }
            return foundEmp;
        }

        public List<Employee> Employees { get; private set;}
    }
}