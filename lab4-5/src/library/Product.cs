using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Product
    {
        public Product(string name, string description, DateTime startDate, double price, int vat)
        {
        // {
        //     Name = name;
        //     Description = description;
        //     StartDate = startDate;
        //     Price = price;
        //     Vat = vat;
        //     Id = Guid.NewGuid();
        //     EndDate = DateTime.MinValue;
        }
        public Guid Id { get; private set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; private set; }
        
        public string Description { get; private set; }
        [Required]
        
        public DateTime StartDate { get; private set; }
        
        public DateTime? EndDate { get; private set; }
        
        public double Price { get; private set; }
        
        [Required]
        public int Vat { get; private set; }


        public double ComputeVat()
        {
            return Price * Vat / 100;
        }

        public bool IsValid()
        {
            //return EndDate.Subtract(StartDate).Seconds >= 0;
            return true;
        }

        public void SetValidity(DateTime endDate)
        {
            if (endDate < StartDate)
            {
                throw new ArgumentException("End date is not valid");
            }

            EndDate = endDate;
        }
    }
}
