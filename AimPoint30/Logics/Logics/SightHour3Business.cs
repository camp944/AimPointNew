using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightHour3Business
    {
        public SightHour3 ListarPorData(string date)
        {
            SightHour3DAO day1 = new SightHour3DAO();
            return day1.ListarPorId(date);
        }
        public List<SightHour3ViewModel> Listar()
        {
            SightHour3DAO dao = new SightHour3DAO();
            return dao.Listar();
        }

        public bool Salvar(SightHour3 animal)
        {
            SightHour3DAO dao = new SightHour3DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightHour3 animal)
        {
            SightHour3DAO dao = new SightHour3DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightHour3 animal)
        {
            SightHour3DAO dao = new SightHour3DAO();
            return dao.Deletar(animal);
        }


    }
}