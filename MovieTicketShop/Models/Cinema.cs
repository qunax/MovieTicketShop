﻿using System.ComponentModel.DataAnnotations;

namespace MovieTicketShop.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string CinemaLogoURL { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
