using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketElevator.Models
{ 
    public class ProductsViewModel
    {   
        public IEnumerable<Buildings> Buildings { get; set; }
        public IEnumerable<Batteries> Batteries { get; set; }
        public IEnumerable<Columns> Columns { get; set; }
        public IEnumerable<Elevators> Elevators { get; set; }
    }
}