using System;

namespace Company
{
    public abstract class Employee
    {       
        public Employee(Guid IdValue, string firstName, string lastName, DateTime startDate, int salary)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StartDate = startDate;
            this.EndDate = DateTime.MinValue;
            this.Salary = salary;
        }

        public Guid Id { get; protected set; }
        public string  FirstName { get; protected set; }
        public string  LastName { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public int Salary { get; protected set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName; 
        }

        public bool IsActive()
        {
            if (EndDate == DateTime.MinValue)
                return true;
            if (EndDate > DateTime.Now)
                return true;
            return false;
        }

        public void QuitMyJob(DateTime endDate)
        {
            if(this.StartDate > endDate)
            {
                throw new ArgumentException("You can't quit before being hired.");
            }
            this.EndDate = endDate;
        }

        public abstract string Salutation();
    }
    
}