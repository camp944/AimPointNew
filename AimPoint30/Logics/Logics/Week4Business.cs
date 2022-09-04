using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Week4Business
    {
        public Week4 ListarPorData(string date)
        {
            Week4DAO day1 = new Week4DAO();
            return day1.ListarPorId(date);
        }
        public List<Week4ViewModel> Listar()
        {
            Week4DAO dao = new Week4DAO();
            return dao.Listar();
        }

        public bool Salvar(Week4 animal)
        {
            Week4DAO dao = new Week4DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Week4 animal)
        {
            Week4DAO dao = new Week4DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Week4 animal)
        {
            Week4DAO dao = new Week4DAO();
            return dao.Deletar(animal);
        }


    }
}