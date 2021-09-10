using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketElevator.Models;

namespace RocketElevator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly RocketContext _context;

        public ProductsController(RocketContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {   
            IEnumerable<Products> objList = _context.Products;
            return View(objList);
        }
    }
}