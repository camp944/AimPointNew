
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class Min30DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Min30DAO));

        //Salvar
        public bool Salvar(Min30 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.Min30s.Add(refTime);

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
        public bool Editar(Min30 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.Min30s.Update(day1);
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
        public bool Deletar(Min30 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.Min30s.Remove(refTime);
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
        public List<Min30ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var Min30View = (from a in _context.Min30s
                                    select new Min30ViewModel
                                    {
                                        Id = a.Id,
                                        Price = a.Price,
                                        DateRequest = a.DateRequest,

                                    }).ToList();

                    return Min30View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public Min30 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.Min30s.Where(a => a.DateRequest == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}