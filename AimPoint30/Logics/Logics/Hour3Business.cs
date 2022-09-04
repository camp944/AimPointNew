using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Hour3Business
    {
        public Hour3 ListarPorData(string date)
        {
            Hour3DAO day1 = new Hour3DAO();
            return day1.ListarPorId(date);
        }
        public List<Hour3ViewModel> Listar()
        {
            Hour3DAO dao = new Hour3DAO();
            return dao.Listar();
        }

        public bool Salvar(Hour3 animal)
        {
            Hour3DAO dao = new Hour3DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Hour3 animal)
        {
            Hour3DAO dao = new Hour3DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Hour3 animal)
        {
            Hour3DAO dao = new Hour3DAO();
            return dao.Deletar(animal);
        }


    }
}