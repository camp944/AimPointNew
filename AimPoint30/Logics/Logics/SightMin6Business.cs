using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightMin6Business
    {
        public SightMin6 ListarPorData(string date)
        {
            SightMin6DAO day1 = new SightMin6DAO();
            return day1.ListarPorId(date);
        }
        public List<SightMin6ViewModel> Listar()
        {
            SightMin6DAO dao = new SightMin6DAO();
            return dao.Listar();
        }

        public bool Salvar(SightMin6 animal)
        {
            SightMin6DAO dao = new SightMin6DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightMin6 animal)
        {
            SightMin6DAO dao = new SightMin6DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightMin6 animal)
        {
            SightMin6DAO dao = new SightMin6DAO();
            return dao.Deletar(animal);
        }


    }
}