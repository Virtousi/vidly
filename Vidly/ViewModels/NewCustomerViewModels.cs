using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModels
    {
        //to ienumerable all the datas 
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customer { get; set; }
    }
}