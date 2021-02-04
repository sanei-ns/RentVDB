using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class Genre
    {
        private int _id;
        private string _name;

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
    }
}