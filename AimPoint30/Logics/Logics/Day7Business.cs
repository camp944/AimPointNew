using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Day7Business
    {
        public Day7 ListarPorData(string date)
        {
            Day7DAO day1 = new Day7DAO();
            return day1.ListarPorId(date);
        }
        public List<Day7ViewModel> Listar()
        {
            Day7DAO dao = new Day7DAO();
            return dao.Listar();
        }

        public bool Salvar(Day7 animal)
        {
            Day7DAO dao = new Day7DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Day7 animal)
        {
            Day7DAO dao = new Day7DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Day7 animal)
        {
            Day7DAO dao = new Day7DAO();
            return dao.Deletar(animal);
        }


    }
}