using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPrefSurvey.Models
{
    public class ResultsViewModel
    {
        [Display(Name = "Total Surveys")]
        public int TotSurv { get; set; }
        [Display(Name = "Average Age")]
        public double AveAge { get; set; }
        [Display(Name = "Oldest person")]
        public int MaxAge { get; set;}
        [Display(Name = "Youngest person")]
        public int MinAge { get; set; }

        [Display(Name = "Pizza (%)")]
        public double PercPizza { get; set; }
        [Display(Name = "Pasta (%)")]
        public double PercPasta { get; set; }
        [Display(Name = "Pap and Wors (%)")]
        public double paw { get; set; }

        [Display(Name = "Eat out (avg)")]
        public double EatOut { get; set; }
        [Display(Name = "Movies (avg)")]
        public double Movies { get; set; }
        [Display(Name = "TV (avg)")]
        public double Tv { get; set; }
        [Display(Name = "Radio (avg)")]
        public double Radio { get; set; }
    }

   
}