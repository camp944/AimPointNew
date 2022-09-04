using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Min6Business
    {
        public Min6 ListarPorData(string date)
        {
            Min6DAO day1 = new Min6DAO();
            return day1.ListarPorId(date);
        }
        public List<Min6ViewModel> Listar()
        {
            Min6DAO dao = new Min6DAO();
            return dao.Listar();
        }

        public bool Salvar(Min6 animal)
        {
            Min6DAO dao = new Min6DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Min6 animal)
        {
            Min6DAO dao = new Min6DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Min6 animal)
        {
            Min6DAO dao = new Min6DAO();
            return dao.Deletar(animal);
        }


    }
}