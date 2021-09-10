using Microsoft.AspNetCore.Mvc;
using RocketElevator.Models;
using RocketElevator.Utils;
using System.Linq;

namespace RocketElevator.Controllers
{
    public class AuthController : Controller
    {
        private readonly RocketContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public AuthController(RocketContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        [HttpPost]
        [Route("/login", Name = "Login")]
        public IActionResult Login(string email, string password)
        {

            var dto = _context.Users.Where(u => u.Email.Equals(email))
                                  .FirstOrDefault();

            //var db = new Users();
            //db.FirstName = "Spencer";
            //db.LastName = "Scot";
            //db.Email = "spencerscot@gmail.com";
            //db.EncryptedPassword = _passwordHasher.Hash("1234");
            //db.CreatedAt = new System.DateTime().Date;
            //db.UpdatedAt = new System.DateTime().Date;
            //_context.Users.Add(db);
            //_context.SaveChanges();

            var db = new Users();
            db.FirstName = "Emmanuel";
            db.LastName = "Sarpong";
            db.Email = "emmanuel.sarpong12@gmail.com";
            db.EncryptedPassword = _passwordHasher.Hash("1234");
            db.CreatedAt = new System.DateTime().Date;
            db.UpdatedAt = new System.DateTime().Date;
            _context.Users.Add(db);
            // _context.SaveChanges();

            if (dto == null)
            {
                TempData["LoginError"] = "This email doesn't exist";
                return RedirectToRoute("ShowLogin");
            }

            (bool verified, bool needsUpgrade) = _passwordHasher.Check(dto.EncryptedPassword, password);

            if (dto.IsUser == true && verified)
            {
                HttpContext.Session.SetObjectAsJson("user", dto);

                return RedirectToAction("Index", "Home");
            }

            // if password mismatch redirect to login page
            TempData["LoginError"] = "Email or password is incorrect";
            return RedirectToRoute("ShowLogin");
        }

        [HttpPost]
        [Route("/logout", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
