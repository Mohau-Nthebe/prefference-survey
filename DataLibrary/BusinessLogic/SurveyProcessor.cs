using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class SurveyProcessor
    {
        public static int CaptureDetails( string surname, string firstNames, string contact,  string date, int age
            , bool pizza, bool pasta, bool papWors, bool chickenStir, bool beefStir, bool others,
            int eatOut, int watchMovies, int watchTv, int radio)
        {
            DetailsModel data = new DetailsModel
            {

                Surname = surname,
                FirstNames = firstNames,
                Contact = contact,
                Date = date,
                Age = age,
                Pizza = pizza,
                Pasta = pasta,
                PapWors = papWors,
                ChickenStir = chickenStir,
                BeefStir = beefStir,
                Other = others,
                EatOut = eatOut,
                WatchMovies = watchMovies,
                WatchTv = watchMovies,
                Radio = radio
            };

            string sql = @"insert into dbo.tbl_surveys ( Surname, FirstNames, Contact,  Date, Age
                            , Pizza, Pasta, PapWors, ChickenStir, BeefStir,  Other,
                                EatOut,  WatchMovies,  WatchTv, Radio)
                values ( @Surname, @FirstNames, @Contact,   @Date, @Age,
                    @Pizza, @Pasta, @PapWors, @ChickenStir, @BeefStir, @Other,
                    @EatOut,  @WatchMovies,  @WatchTv, @Radio);";
            return SqlDataAccess.SaveData(sql, data);

        }

    }
}
