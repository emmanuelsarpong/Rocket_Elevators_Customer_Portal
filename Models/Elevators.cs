using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RocketElevator.Models
{
    public partial class Elevators
    {
        [Key]
        public long Id { get; set; }
        public long? ColumnId { get; set; }
        public string SerialNumber { get; set; }
        public string ElevatorModel { get; set; }
        public string ElevatorType { get; set; }
        public string ElevatorStatus { get; set; }
        public DateTime? DateOfCommissioning { get; set; }
        public DateTime? DateOfLastInspection { get; set; }
        public string CertificateOfInspection { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // public long? column_id { get; set; }
        // public string serial_number { get; set; }
        // public string model { get; set; }
        // public string id { get; set; }
        // public string status { get; set; }
    }
}
