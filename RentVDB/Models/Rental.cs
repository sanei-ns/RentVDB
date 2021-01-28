using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class Rental
    {

        public int Id { get; set; }

        public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; }

        public int MovieId { get; set; }
        [Required]
        public MovieMay Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}