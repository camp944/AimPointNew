
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class Min6DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Min6DAO));

        //Salvar
        public bool Salvar(Min6 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.Min6s.Add(refTime);

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
        public bool Editar(Min6 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.Min6s.Update(day1);
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
        public bool Deletar(Min6 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.Min6s.Remove(refTime);
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
        public List<Min6ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var Min6View = (from a in _context.Min6s
                                    select new Min6ViewModel
                                    {
                                        Id = a.Id,
                                        Price = a.Price,
                                        DateRequest = a.DateRequest,

                                    }).ToList();

                    return Min6View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public Min6 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.Min6s.Where(a => a.DateRequest == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}