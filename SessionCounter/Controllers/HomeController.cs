using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionCounter.Models;

namespace SessionCounter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActiveSessionsCount = Infrastructure.ApplicationState.ActiveSessions.Count;
            return View();
        }
    }
}
