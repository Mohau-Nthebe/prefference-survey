using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPrefSurvey.Models
{
    public class SurveyModel
    {
        //Personal Details
        [Required(ErrorMessage = "Surname is required")]
        [Display(Name="Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Names")]
        public string FirstNames { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [Display(Name = "Contact Number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Range(5,120)]
        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        //Favourite Food 
        [Display(Name = "Pizza")]
        public bool Pizza { get; set; }
        [Display(Name = "Pasta")]
        public bool Pasta { get; set; }
        [Display(Name = "Pap and Wors")]
        public bool PapWors { get; set; }
        [Display(Name = "Chicken stir fry")]
        public bool ChickenStir { get; set; }
        [Display(Name = "Beef stir fry")]
        public bool BeefStir { get; set; }
        [Display(Name = "Other")]
        public bool Other { get; set; }

        //Habits

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5)]
        [Display(Name = "I like to eat out")]
        public int EatOut { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5)]
        [Display(Name = "I like to watch movies")]
        public int WatchMovies { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5)]
        [Display(Name = "I like to watch Tv")]
        public int WatchTV { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5)]
        [Display(Name = "I like to listen to the radio")]
        public int Radio { get; set; }
    }
}