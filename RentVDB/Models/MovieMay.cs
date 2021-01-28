using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace RentVDB.Models
{
    public class MovieMay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
        public int? ImageId { get; set; }
        [Display(Name = "Image")]
        public ImageMv Image { get; set; }
    }

}