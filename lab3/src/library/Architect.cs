using System;

namespace Company
{
    public class Architect : Employee
    {
        public Architect(Guid id, 
                         string firstName, 
                         string lastName, 
                         DateTime startDate, 
                         int salary) : 
        base(id, firstName, lastName, startDate, salary)
        {}


        public override string Salutation()
        {
            return "Hello architect " + FirstName;
        }
    }
}
