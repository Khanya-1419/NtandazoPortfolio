using Microsoft.AspNetCore.Mvc;

namespace NtandazoPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Projects() => View();
        public IActionResult Contact() => View();
    }
}
