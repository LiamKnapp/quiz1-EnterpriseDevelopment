using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {

        // Add a reference to the increment service
        private IincrementPageCount _incrementPage;

        // Add a param to the increment service in the constructor
        public HomeController(IincrementPageCount incrementPage)
        {

            // Assign to private data field
            _incrementPage = incrementPage;

        }

        public IActionResult Index()
        {

            // Increment the page count given the name
            _incrementPage.HandlePageCount("Index");

            // Get the page count given the name
            int visitCount = _incrementPage.GetPageCount("Index");

            return View(visitCount);
        }

        public IActionResult OtherPage()
        {

            // Increment the page count given the name
            _incrementPage.HandlePageCount("OtherPage");

            // Get the page count given the name
            int visitCount = _incrementPage.GetPageCount("OtherPage");

            return View(visitCount);
        }
    }
}