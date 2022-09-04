
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class SightWeek4DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SightWeek4DAO));

        //Salvar
        public bool Salvar(SightWeek4 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.SightWeek4s.Add(refTime);

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
        public bool Editar(SightWeek4 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.SightWeek4s.Update(day1);
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
        public bool Deletar(SightWeek4 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.SightWeek4s.Remove(refTime);
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
        public List<SightWeek4ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var SightWeek4View = (from a in _context.SightWeek4s
                                    select new SightWeek4ViewModel
                                    {
                                        Id = a.Id,
                                        DateInit = a.DateInit,
                                        PriceInit = a.PriceInit,
                                        PriceTarget = a.PriceTarget,
                                        DateEnd = a.DateEnd,
                                        PriceEnd = a.PriceEnd,

                                    }).ToList();

                    return SightWeek4View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public SightWeek4 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.SightWeek4s.Where(a => a.DateInit == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}