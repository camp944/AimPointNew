
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class Hour3DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Hour3DAO));

        //Salvar
        public bool Salvar(Hour3 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.Hour3s.Add(refTime);

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
        public bool Editar(Hour3 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.Hour3s.Update(day1);
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
        public bool Deletar(Hour3 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.Hour3s.Remove(refTime);
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
        public List<Hour3ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var Hour3View = (from a in _context.Hour3s
                                    select new Hour3ViewModel
                                    {
                                        Id = a.Id,
                                        Price = a.Price,
                                        DateRequest = a.DateRequest,

                                    }).ToList();

                    return Hour3View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public Hour3 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.Hour3s.Where(a => a.DateRequest == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}