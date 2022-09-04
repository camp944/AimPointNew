using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class DashboardDAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(DashboardDAO));

        public DashboardViewModel ObterDashboardValores()
        {   
            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.Vhour3 = ObterValorHour3();
            dashboard.Vday7 = ObterValorDay7();
            dashboard.Vday1 = ObterValorDay1();
            dashboard.Vmin30 = ObterValorMin30();
            dashboard.Vmin6 = ObterValorMin6();
            dashboard.Vweek4 = ObterValorWeek4();

            return dashboard;

        }

        public SightDay1ViewModel ObterValorDay1()
        {
            
            var day1 = new SightDay1DAO();
            var Day1View = day1.Listar();

            if (Day1View.Count > 0)
            {
                return Day1View[Day1View.Count - 1];
            }
            else
            {
                return null;
            }


        }


        public SightDay7ViewModel ObterValorDay7()
        {

            var day7 = new SightDay7DAO();
            var Day7View = day7.Listar();

            if (Day7View.Count > 0)
            {
                return Day7View[Day7View.Count - 1];
            }
            else
            {
                return null;
            }


        }

        public SightMin6ViewModel ObterValorMin6()
        {

            var min6 = new SightMin6DAO();
            var Min6View = min6.Listar();

            if (Min6View.Count > 0)
            {
                return Min6View[Min6View.Count - 1];
            }
            else
            {
                return null;
            }


        }

        public SightMin30ViewModel ObterValorMin30()
        {

            var min30 = new SightMin30DAO();
            var Min30View = min30.Listar();

            if (Min30View.Count > 0)
            {
                return Min30View[Min30View.Count - 1];
            }
            else
            {
                return null;
            }

        }

        public SightHour3ViewModel ObterValorHour3()
        {

            var hour3 = new SightHour3DAO();
            var Hour3View = hour3.Listar();
            if(Hour3View.Count>0)
            {
                return Hour3View[Hour3View.Count - 1];
            }
            else
            {
                return null;
            }
            

        }

        public SightWeek4ViewModel ObterValorWeek4()
        {

            var week4 = new SightWeek4DAO();
            var Week4View = week4.Listar();

            if (Week4View.Count > 0)
            {
                return Week4View[Week4View.Count - 1];
            }
            else
            {
                return null;
            }

        }
    }
}