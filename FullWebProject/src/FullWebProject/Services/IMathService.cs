namespace FullWebProject.Services
{
    public interface IMathService
    {
        int AddNumbers(params int[] numbers);
        int MultiplyNumbers(params int[] numbers);
    }
}
