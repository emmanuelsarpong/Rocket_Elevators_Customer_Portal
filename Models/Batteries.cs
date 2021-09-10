using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RocketElevator.Models
{
    public partial class Batteries
    {
        [Key]
        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public long? EmployeeId { get; set; }
        public string BatteryType { get; set; }
        public string BatteryStatus { get; set; }
        public DateTime? DateOfCommissioning { get; set; }
        public DateTime? DateOfLastInspection { get; set; }
        public string CertificateOfOperations { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // public long? id { get; set; }
        // public long? building_id { get; set; }
        // public long? employee_id { get; set; }
        // public string building_type { get; set; }
        // public string status { get; set; }
        // public string certificate_of_operations { get; set; }

        // public List<Columns> Columns { get; set; }
    }
}
