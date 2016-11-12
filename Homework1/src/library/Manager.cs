using System;


namespace Company
{
    public class Manager : Employee
    {
        public Manager(Guid id, 
                         string firstName, 
                         string lastName, 
                         DateTime startDate, 
                         int salary) : 
        base(id, firstName, lastName, startDate, salary)
        {}
        

        public override string Salutation()
        {
            return "Hello manager " + FirstName;
        }
    }
}
