using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class DashboardBusiness
    {
        
        public DashboardViewModel ObterDashboardValores()
        {
            DashboardDAO dao = new DashboardDAO();
            return dao.ObterDashboardValores();
        }

       


    }
}