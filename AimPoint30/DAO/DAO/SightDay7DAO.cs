
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class SightDay7DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SightDay7DAO));

        //Salvar
        public bool Salvar(SightDay7 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.SightDay7s.Add(refTime);

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
        public bool Editar(SightDay7 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.SightDay7s.Update(day1);
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
        public bool Deletar(SightDay7 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.SightDay7s.Remove(refTime);
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
        public List<SightDay7ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var SightDay7View = (from a in _context.SightDay7s
                                    select new SightDay7ViewModel
                                    {
                                        Id = a.Id,
                                        DateInit = a.DateInit,
                                        PriceInit = a.PriceInit,
                                        PriceTarget = a.PriceTarget,
                                        DateEnd = a.DateEnd,
                                        PriceEnd = a.PriceEnd,

                                    }).ToList();

                    return SightDay7View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public SightDay7 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.SightDay7s.Where(a => a.DateInit == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}