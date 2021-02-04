using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class CustomerFormViewModel
    {
        private IEnumerable<MembershipType> _membershipTypes;
        private Customer _customer;

        public IEnumerable<MembershipType> MembershipTypes
        {
            get => _membershipTypes;
            set => _membershipTypes = value;
        }

        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }
    }
}