using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RocketElevator.Models;
using RocketElevator.Utils;
using System;
using System.Diagnostics;
using System.Linq;

namespace RocketElevator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RocketContext _context;

        public HomeController(RocketContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("intervention", Name = "ShowIntervation")]
        public IActionResult Intervention()
        {
            var user = HttpContext.Session.GetObjectFromJson<Users>("user");

            if(user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new InterventionFormViewModel();

            model.Batteries = _context.Batteries.ToList();
            model.Elevators = _context.Elevators.ToList();
            model.Columns = _context.Columns.ToList();
            model.Buildings = _context.Buildings.ToList();

            ViewBag.ErrorMessage = TempData.ContainsKey("ErrorMessage") ? TempData["ErrorMessage"].ToString() : String.Empty;
            ViewBag.SuccessMessage = TempData.ContainsKey("SuccessMessage") ? TempData["SuccessMessage"].ToString() : String.Empty;

            return View(model);
        }


        [HttpPost]
        [Route("intervention", Name = "Intervation")]
        public IActionResult CreateIntervention(Interventions dto)
        {
            var user = HttpContext.Session.GetObjectFromJson<Users>("user");

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            dto.Author = (int)user.Id;
            dto.CustomerId = (int)user.Id;

            _context.Interventions.Add(dto);
            var ret =  _context.SaveChanges();

            if(ret > 0)
            {
                TempData["SuccessMessage"] = "Intervention has been created successfully";
                return RedirectToAction("Intervention", "Home");
            }

            TempData["ErrorMessage"] = "Unable to Create Intervention Now";
            return RedirectToAction("Intervention", "Home");
        }


        [HttpGet]
        [Route("products", Name = "ShowProducts")]
        public IActionResult Products()
        {
            var user = HttpContext.Session.GetObjectFromJson<Users>("user");

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new ProductsViewModel();

            model.Batteries = _context.Batteries.ToList();
            model.Elevators = _context.Elevators.ToList();
            model.Columns = _context.Columns.ToList();
            model.Buildings = _context.Buildings.ToList();

            ViewBag.ErrorMessage = TempData.ContainsKey("ErrorMessage") ? TempData["ErrorMessage"].ToString() : String.Empty;
            ViewBag.SuccessMessage = TempData.ContainsKey("SuccessMessage") ? TempData["SuccessMessage"].ToString() : String.Empty;

            return View(model);
        }

        [HttpGet]
        [Route("login", Name = "ShowLogin")]
        public IActionResult Login()
        {
            var user = HttpContext.Session.GetObjectFromJson<Users>("user");

            if (user == null)
            {
                ViewBag.LoginError = TempData.ContainsKey("LoginError") ? TempData["LoginError"].ToString() : String.Empty;
                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
