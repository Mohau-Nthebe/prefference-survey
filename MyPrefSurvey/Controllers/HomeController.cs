using MyPrefSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.SurveyProcessor;
using static DataLibrary.BusinessLogic.ResultsProcessor;
using DataLibrary.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataLibrary.DataAccess;

namespace MyPrefSurvey.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult FillTheSurvey()
        {
            ViewBag.Message = "Fill out the Survey";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FillTheSurvey(DetailsModel dmodel)
        {
            if(ModelState.IsValid)
            {
                CaptureDetails(  dmodel.Surname, dmodel.FirstNames, dmodel.Contact,  dmodel.Date, dmodel.Age,
                                dmodel.Pizza, dmodel.Pasta, dmodel.PapWors, dmodel.ChickenStir, dmodel.BeefStir, dmodel.Other,
                                dmodel.EatOut, dmodel.WatchMovies, dmodel.WatchTv, dmodel.Radio);
                
                TransfareDetData();
                

                return RedirectToAction("Index");
            }

            return View();
        }



        public ActionResult ViewResults()
        {
            ViewBag.Message = " Results Dashboard";

            var data = LoadResults();

            List<ResultsViewModel> results = new List<ResultsViewModel>();

            foreach (var row in data)
            {
                results.Add(new ResultsViewModel
                {
                    TotSurv = row.TotSurv,
                    AveAge = row.AveAge,
                    MaxAge=row.MaxAge,
                    MinAge=row.MinAge,

                    PercPizza=row.Pizza,
                    PercPasta=row.Pasta,
                    paw = row.paw,

                    EatOut=row.EatOut,
                    Movies=row.Movies,
                    Tv=row.Tv,
                    Radio=row.Radio


                });
            }

            


            return View(results);
        }



    }
}