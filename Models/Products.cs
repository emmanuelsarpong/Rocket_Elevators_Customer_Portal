using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RocketElevator.Models
{
    public partial class Products
    {
        [Key]
        public long Id { get; set; }
        public int BuildingId { get; set; }
        public int? BatteryId { get; set; }
        public int? ColumnId { get; set; }
        public int? ElevatorId { get; set; }
        public int? EmployeeId { get; set; }
        

        // public IEnumerable<Buildings> Buildings { get; set; }
        // public IEnumerable<Batteries> Batteries { get; set; }
        // public IEnumerable<Columns> Columns { get; set; }
        // public IEnumerable<Elevators> Elevators { get; set; }
    }
}
