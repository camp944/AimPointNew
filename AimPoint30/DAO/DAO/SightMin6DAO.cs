
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class SightMin6DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SightMin6DAO));

        //Salvar
        public bool Salvar(SightMin6 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.SightMin6s.Add(refTime);

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
        public bool Editar(SightMin6 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.SightMin6s.Update(day1);
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
        public bool Deletar(SightMin6 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.SightMin6s.Remove(refTime);
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
        public List<SightMin6ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var SightMin6View = (from a in _context.SightMin6s
                                    select new SightMin6ViewModel
                                    {
                                        Id = a.Id,
                                        DateInit = a.DateInit,
                                        PriceInit = a.PriceInit,
                                        PriceTarget = a.PriceTarget,
                                        DateEnd = a.DateEnd,
                                        PriceEnd = a.PriceEnd,

                                    }).ToList();

                    return SightMin6View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public SightMin6 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.SightMin6s.Where(a => a.DateInit == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}