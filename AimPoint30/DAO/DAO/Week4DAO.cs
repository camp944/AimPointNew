
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class Week4DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Week4DAO));

        //Salvar
        public bool Salvar(Week4 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.Week4s.Add(refTime);

                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //Editar
        public bool Editar(Week4 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.Week4s.Update(day1);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //Deletar
        public bool Deletar(Week4 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.Week4s.Remove(refTime);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //Listar
        public List<Week4ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var Week4View = (from a in _context.Week4s
                                    select new Week4ViewModel
                                    {
                                        Id = a.Id,
                                        Price = a.Price,
                                        DateRequest = a.DateRequest,

                                    }).ToList();

                    return Week4View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public Week4 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.Week4s.Where(a => a.DateRequest == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}