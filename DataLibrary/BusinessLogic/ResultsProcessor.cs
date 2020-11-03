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
    public static  class ResultsProcessor
    {
        public static int TransfareDetData()
        {
            ResultsModel data = new ResultsModel
            {

            };


            string sql = @"insert into dbo.tbl_results ( totsurv, aveage, maxage, minage,
                           eatout, movies, tv, radio,
                            pizza, pasta, paw)
                         select count(surname), avg(age), max(age), min(age) ,
                           avg(eatOut), avg(watchMovies), avg(watchTv), avg(radio), 
                           (select count(pizza) from dbo.tbl_surveys where pizza=1 group by pizza)*100/count(pizza),
                           (select count(pasta) from dbo.tbl_surveys where pasta=1 group by pasta)*100/count(pasta),
                           (select count(papwors) from dbo.tbl_surveys where papwors=1 group by papwors)*100/count(pasta)
                           from dbo.tbl_surveys  ;";
            return SqlDataAccess.SaveData(sql, data);

        }


        public static List<ResultsModel> LoadResults()
        {
            string sql = @"select TotSurv, AveAge, MaxAge, MinAge, Pizza, Pasta, paw, EatOut, Movies, Tv, Radio from dbo.tbl_results where id=(select max(id) from dbo.tbl_results) ";

            return SqlDataAccess.LoadData<ResultsModel>(sql);
        }

                
    }
}
