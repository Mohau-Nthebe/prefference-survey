using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ResultsModel
    {
        public int TotSurv {get;set;}
        public double AveAge { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }

        public double Pizza { get; set; }
        public double Pasta { get; set; }
        public double paw { get; set; }

        public double EatOut { get; set; }
        public double Movies { get; set; }
        public double Tv { get; set; }
        public double Radio { get; set; }





    }
}
