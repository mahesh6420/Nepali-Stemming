using Microsoft.AspNetCore.Mvc;

namespace Stemming.Controllers
{
    public class RootsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}