using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private bool _isSubscribedToNewsletter;
        private MembershipType _membershipType;
        private int _membershipTypeId;
        private DateTime? _birthdate;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public bool IsSubscribedToNewsletter
        {
            get => _isSubscribedToNewsletter;
            set => _isSubscribedToNewsletter = value;
        }

        public MembershipType MembershipType
        {
            get => _membershipType;
            set => _membershipType = value;
        }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId
        {
            get => _membershipTypeId;
            set => _membershipTypeId = value;
        }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]

        public DateTime? Birthdate
        {
            get => _birthdate;
            set => _birthdate = value;
        }
    }
}