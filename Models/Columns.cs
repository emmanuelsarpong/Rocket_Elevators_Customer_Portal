using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RocketElevator.Models
{
    public partial class Columns
    {   
        [Key]
        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public string ColumnType { get; set; }
        public string ColumnStatus { get; set; }
        public int? NumberOfFloorsServed { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // public List<Elevators> Elevators { get; set; }

        // public long id { get; set; }
        // public long? battery_id { get; set; }
        // public string column_type { get; set; }
        // public string information { get; set; }
        // public string status { get; set; }

    }
}
