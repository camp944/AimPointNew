
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class Day7DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Day7DAO));

        //Salvar
        public bool Salvar(Day7 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.Day7s.Add(refTime);

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
        public bool Editar(Day7 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.Day7s.Update(day1);
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
        public bool Deletar(Day7 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.Day7s.Remove(refTime);
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
        public List<Day7ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var Day7View = (from a in _context.Day7s
                                    select new Day7ViewModel
                                    {
                                        Id = a.Id,
                                        Price = a.Price,
                                        DateRequest = a.DateRequest,

                                    }).ToList();

                    return Day7View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public Day7 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.Day7s.Where(a => a.DateRequest == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}