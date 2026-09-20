using MathLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MathLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hesaplama()
        {
            return View();
        }

        public IActionResult Fonksiyonlar()
        {
            return View();
        }

        public IActionResult Istatistik()
        {
            return View();
        }

        public IActionResult MatematikAraclari()
        {
            return View();
        }
        public IActionResult Integral()
        {
            return View();
        }
        public IActionResult Denklem()
        {
            return View();
        }
        public IActionResult Grafik()
        {
            return View();
        }
        public IActionResult Turev()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}