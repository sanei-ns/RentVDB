using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentVDB.Models
{
    public class MovieFormViewModel
    {
        private IEnumerable<Genre> _genres;
        private int? _id;
        private string _name;
        private Genre _genre;
        private DateTime? _releaseDate;
        private int? _numberInStock;

        public MovieFormViewModel(MovieMay movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            Genre = movie.Genre;
        }

        public IEnumerable<Genre> Genres
        {
            get => _genres;
            set => _genres = value;
        }

        public int? Id
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

        [Display(Name = "Genre")]
        [Required]
        public Genre Genre
        {
            get => _genre;
            set => _genre = value;
        }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate
        {
            get => _releaseDate;
            set => _releaseDate = value;
        }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public int? NumberInStock
        {
            get => _numberInStock;
            set => _numberInStock = value;
        }

        public string Title => Id != 0 ? "Edit Movie" : "New Movie";

        public MovieFormViewModel()
        {
            Id = 0;
        }
    }
}