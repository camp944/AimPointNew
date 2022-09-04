using AimPoint30.DAO.DAO;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;
using System.Collections.Generic;

namespace AimPoint30.Domain.Logics
{
    public class Day1Business
    {
        public Day1 ListarPorData(string date)
        {
            Day1DAO day1 = new Day1DAO();
            return day1.ListarPorId(date);
        }
        public List<Day1ViewModel> Listar()
        {
            Day1DAO dao = new Day1DAO();
            return dao.Listar();
        }

        public bool Salvar(Day1 animal)
        {
            Day1DAO dao = new Day1DAO();
            return dao.Salvar(animal);
        }

        public bool Editar(Day1 animal)
        {
            Day1DAO dao = new Day1DAO();
            return dao.Editar(animal);
        }

        public bool Deletar(Day1 animal)
        {
            Day1DAO dao = new Day1DAO();
            return dao.Deletar(animal);
        }


    }
}