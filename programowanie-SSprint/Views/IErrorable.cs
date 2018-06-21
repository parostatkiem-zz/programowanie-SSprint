namespace programowanie_SSprint
{
    public interface IErrorable
    {
        void ShowError(string message, string longMessage = null, string title = null);
    }
}
