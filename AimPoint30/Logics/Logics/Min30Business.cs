using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Min30Business
    {
        public Min30 ListarPorData(string date)
        {
            Min30DAO day1 = new Min30DAO();
            return day1.ListarPorId(date);
        }
        public List<Min30ViewModel> Listar()
        {
            Min30DAO dao = new Min30DAO();
            return dao.Listar();
        }

        public bool Salvar(Min30 animal)
        {
            Min30DAO dao = new Min30DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Min30 animal)
        {
            Min30DAO dao = new Min30DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Min30 animal)
        {
            Min30DAO dao = new Min30DAO();
            return dao.Deletar(animal);
        }


    }
}