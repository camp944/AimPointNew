
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class SightHour3DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SightHour3DAO));

        //Salvar
        public bool Salvar(SightHour3 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.SightHour3s.Add(refTime);

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
        public bool Editar(SightHour3 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.SightHour3s.Update(day1);
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
        public bool Deletar(SightHour3 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.SightHour3s.Remove(refTime);
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
        public List<SightHour3ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var SightHour3View = (from a in _context.SightHour3s
                                    select new SightHour3ViewModel
                                    {
                                        Id = a.Id,
                                        DateInit = a.DateInit,
                                        PriceInit = a.PriceInit,
                                        PriceTarget = a.PriceTarget,
                                        DateEnd = a.DateEnd,
                                        PriceEnd = a.PriceEnd,

                                    }).ToList();

                    return SightHour3View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public SightHour3 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.SightHour3s.Where(a => a.DateInit == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}