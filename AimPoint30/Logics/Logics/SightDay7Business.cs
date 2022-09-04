using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightDay7Business
    {
        public SightDay7 ListarPorData(string date)
        {
            SightDay7DAO day1 = new SightDay7DAO();
            return day1.ListarPorId(date);
        }
        public List<SightDay7ViewModel> Listar()
        {
            SightDay7DAO dao = new SightDay7DAO();
            return dao.Listar();
        }

        public bool Salvar(SightDay7 animal)
        {
            SightDay7DAO dao = new SightDay7DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightDay7 animal)
        {
            SightDay7DAO dao = new SightDay7DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightDay7 animal)
        {
            SightDay7DAO dao = new SightDay7DAO();
            return dao.Deletar(animal);
        }


    }
}