using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BasicFilmDbProject.Models
{
    public class FilmForm

    {
        [Key]
       
        public int FilmID { get; set; }
        [Required(ErrorMessage = "All good films need a name")]
        public string FilmTitle { get; set; }
        [Required(ErrorMessage = "All good films need a age rating")]
        public string FilmCertificate { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage { get; set; }
        public decimal FilmPrice { get; set; }

        public int Stars { get; set; }

        public DateTime ReleaseDate { get; set; }

        

    }

}