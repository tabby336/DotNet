using System;

namespace DataLayer
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public string PhoneNumber { get; private set;}

        public string Email {get; private set;}
        
    }
}