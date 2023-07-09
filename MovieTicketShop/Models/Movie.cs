using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieTicketShop.Models.Enums;

namespace MovieTicketShop.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Movie Picture")]
        public string MoviePictureURL { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Ticket Price)")]
        public double Price { get; set; }

        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }



        //Relationships
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema CinemaName { get; set; }


        public List<Actor_Movie> Actors_Movies { get; set; }


        public int MovieProducerId { get; set; }
        [ForeignKey("MovieProducerId")]
        public Producer MovieProducer { get; set; }

    }
}
