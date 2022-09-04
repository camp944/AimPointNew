using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class SightMin30Business
    {
        public SightMin30 ListarPorData(string date)
        {
            SightMin30DAO day1 = new SightMin30DAO();
            return day1.ListarPorId(date);
        }
        public List<SightMin30ViewModel> Listar()
        {
            SightMin30DAO dao = new SightMin30DAO();
            return dao.Listar();
        }

        public bool Salvar(SightMin30 animal)
        {
            SightMin30DAO dao = new SightMin30DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(SightMin30 animal)
        {
            SightMin30DAO dao = new SightMin30DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(SightMin30 animal)
        {
            SightMin30DAO dao = new SightMin30DAO();
            return dao.Deletar(animal);
        }


    }
}