using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightDay1Business
    {
        public SightDay1 ListarPorData(string date)
        {
            SightDay1DAO day1 = new SightDay1DAO();
            return day1.ListarPorId(date);
        }
        public List<SightDay1ViewModel> Listar()
        {
            SightDay1DAO dao = new SightDay1DAO();
            return dao.Listar();
        }

        public bool Salvar(SightDay1 animal)
        {
            SightDay1DAO dao = new SightDay1DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightDay1 animal)
        {
            SightDay1DAO dao = new SightDay1DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightDay1 animal)
        {
            SightDay1DAO dao = new SightDay1DAO();
            return dao.Deletar(animal);
        }


    }
}