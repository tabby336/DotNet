using System;

namespace WebFormsProject
{
    public class FizzBuzzAlgorithm
    {
        public FizzBuzzAlgorithm(string numAsString)
        {
            NumAsString = numAsString;
        }

        public string GetFizzBuzz()
        {
            string fizzbuzz = "";
            try
            {
                int num = Int32.Parse(NumAsString);
                if (num < 5 || num > 100)
                    return "Not the best number ever.";
                for(int count = 1; count <= num; ++count)
                {
                    if (count % 3 != 0 && count % 5 != 0)
                        fizzbuzz += count.ToString();
                    if (count % 3 == 0)
                        fizzbuzz += "Fizz";
                    if (count % 5 == 0)
                        fizzbuzz += "Buzz";
                }
            } catch(Exception e)
            {
                return "You provided noise.";
            }
            return fizzbuzz;
        }

        private string NumAsString;
    }
}