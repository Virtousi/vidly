using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte ID { get; set; }
        //Excercise 3.1 (Create reference)
        //go to package manager, add-migration AddMemberShipName, Update-database
        public string MembershipName { get; set; }
        public short SignupFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}