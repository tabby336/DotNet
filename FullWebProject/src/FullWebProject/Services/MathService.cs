using System.Linq;

namespace FullWebProject.Services
{
    public class MathService : IMathService
    {
        public int AddNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }
        public int MultiplyNumbers(params int[] numbers)
        {
            return numbers.Aggregate(1, (a,b) => a*b);
        }
    }
}
