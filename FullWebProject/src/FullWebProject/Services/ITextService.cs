namespace FullWebProject.Services
{
    public interface ITextService
    {
        string ConcatInputs(string separator, params string[] inputs);
    }
}
