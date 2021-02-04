using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class MembershipType
    {
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [Required]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int SignUpFee
        {
            get => _signUpFee;
            set => _signUpFee = value;
        }

        public int DurationInMonths
        {
            get => _durationInMonths;
            set => _durationInMonths = value;
        }

        public int DiscountRate
        {
            get => _discountRate;
            set => _discountRate = value;
        }

        public static readonly int Unknown = 0;
        public static readonly int PayAsYouGo = 1;
        private int _id;
        private string _name;
        private int _signUpFee;
        private int _durationInMonths;
        private int _discountRate;
    }
}