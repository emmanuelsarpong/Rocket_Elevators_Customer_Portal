using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RocketElevator.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            Addresses = new HashSet<Addresses>();
            BuildingDetails = new HashSet<BuildingDetails>();
        }
        [Key]
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? AdminContactId { get; set; }
        public long? TechnicalContactId { get; set; }
        public string AdministratorFullName { get; set; }
        public string AdministratorEmail { get; set; }
        public string AdministratorPhoneNumber { get; set; }
        public string TechnicalContactFullName { get; set; }
        public string TechnicalContactEmail { get; set; }
        public string TechnicalContactPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? BuildingDetailId { get; set; }
        public long? AddressId { get; set; }

        public virtual Employees AdminContact { get; set; }
        public virtual Employees TechnicalContact { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<BuildingDetails> BuildingDetails { get; set; }

        // public List<Batteries> Batteries { get; set; }
        // public string full_name_of_the_building_administrator { get; set; }
        // public string id { get; set; }
        
    }
}
