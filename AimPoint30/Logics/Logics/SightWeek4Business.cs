using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightWeek4Business
    {
        public SightWeek4 ListarPorData(string date)
        {
            SightWeek4DAO day1 = new SightWeek4DAO();
            return day1.ListarPorId(date);
        }
        public List<SightWeek4ViewModel> Listar()
        {
            SightWeek4DAO dao = new SightWeek4DAO();
            return dao.Listar();
        }

        public bool Salvar(SightWeek4 animal)
        {
            SightWeek4DAO dao = new SightWeek4DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightWeek4 animal)
        {
            SightWeek4DAO dao = new SightWeek4DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightWeek4 animal)
        {
            SightWeek4DAO dao = new SightWeek4DAO();
            return dao.Deletar(animal);
        }


    }
}