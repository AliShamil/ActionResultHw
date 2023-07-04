using MyMiddleWebServer.ActionResults;

namespace MyMiddleWebServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Content()
        {
            return ContentEx();
        }

        public IActionResult Json()
        {
            return JsonEx();
        }

        public IActionResult Empty()
        {
            return EmptyEx();
        }

        public IActionResult File()
        {
            return FileEx();
        }

        public IActionResult Redirect()
        {
            return RedirectEx();
        }
    }
}
