using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsSubsribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeID { get; set; }
    }
}