namespace FullWebProject.Services
{
    public class TextService : ITextService
    {
        public string ConcatInputs(string separator, params string[] inputs)
        {
            return string.Join(separator, inputs);
        }
    }
}
