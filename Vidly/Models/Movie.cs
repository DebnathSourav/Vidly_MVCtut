﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre Genre { get; set; }


        //Display under what name you want to see in the webpage
        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name ="Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
    }
}