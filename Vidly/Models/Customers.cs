using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int ID { get; set; }

        [Display(Name = "Name of Customer:")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth:")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubsribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeID { get; set; }
    }
}