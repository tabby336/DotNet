using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsProject
{
    public class ComputeAlgorithm
    {
        public ComputeAlgorithm(string numOne, string numTwo, string numThree = "")
        {
            NumOne = numOne;
            NumTwo = numTwo;
            NumThree = numThree;
        }

        public string ComputeSum()
        {
            double sum;
            try
            {
                sum = Double.Parse(NumOne) + Double.Parse(NumTwo) + Double.Parse(NumThree);
            }
            catch (Exception e)
            {
                return "You provided noise.";
            }
            return sum.ToString();
        }

        public string NumOne, NumTwo, NumThree;
    }
}