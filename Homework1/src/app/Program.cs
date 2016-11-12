using System;
using Company;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Architect architect = new Architect(new Guid(), "A", "B", DateTime.Now, 20);
             Console.WriteLine(architect.FirstName);
        }
    }
}
