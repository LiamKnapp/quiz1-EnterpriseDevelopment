namespace PageCounterApp.Services
{
    public class IncrementPageCount : IincrementPageCount // reference the interface
    {
        

        // Create a dictionary to store the page name and its given visit count
        private Dictionary<string, int> PageVisitCount = new Dictionary<string, int>();


        // Method to handle the incrementation of visit count and dictionary entries
        public void HandlePageCount(string pageName)
        {
            Console.WriteLine("In the Increment Page count service constructor");

            // Check to see if given page name exists in the Dictionary
            if (PageVisitCount.ContainsKey(pageName)) 
            {
                // If the page name exists in the dictionary: Increment
                PageVisitCount[pageName]++;
            }
            else
            {
                // Add the page name to the dictionary with an associated visit count
                PageVisitCount[pageName] = 1;
            }
        }


        // Method to return the visit count from the dictionary
        public int GetPageCount(string pageName)
        {

            // Check to see if given page name exists in the Dictionary
            if (PageVisitCount.ContainsKey(pageName) == true)
            {
                // If the page name exists in the dictionary: return visit count
                return PageVisitCount[pageName];
            }
            else
            {
                // The page name does not exist thus, has no visits
                return 0;
            }
        }

    }
}
