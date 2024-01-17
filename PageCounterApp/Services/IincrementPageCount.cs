namespace PageCounterApp.Services
{
    public interface IincrementPageCount
    {
        // Increment the page visit count for the given name
        void HandlePageCount(string pageName);

        // Get the current visit count for the given name
        int GetPageCount(string pageName);

    }
}
