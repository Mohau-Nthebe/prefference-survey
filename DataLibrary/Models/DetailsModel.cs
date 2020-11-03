using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class DetailsModel
    {
        public int SurveyId { get; set; }
        public string Surname { get; set; }
        public string FirstNames { get; set; }
        public string Contact { get; set; }
        public string Date { get; set; }
        public int Age { get; set; }
        public bool Pizza { get; set; }
        public bool Pasta { get; set; }
        public bool PapWors { get; set; }
        public bool ChickenStir { get; set; }
        public bool BeefStir { get; set; }
        public bool Other { get; set; }
        public int Id { get; set; }
        public int EatOut { get; set; }
        public int WatchMovies { get; set; }
        public int WatchTv { get; set; }
        public int Radio { get; set; }
        

    }
}
