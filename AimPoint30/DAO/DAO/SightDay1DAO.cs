
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AimPoint30.Entities.Model;
using AimPoint30.Entities.ViewModels;

namespace AimPoint30.DAO.DAO
{
    public class SightDay1DAO
    { 
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SightDay1DAO));

        //Salvar
        public bool Salvar(SightDay1 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())

                {

                    _context.SightDay1s.Add(refTime);

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
        public bool Editar(SightDay1 day1)
        {
            try
            {


                using (AimPointContext _context = new AimPointContext())
                {
                    _context.SightDay1s.Update(day1);
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
        public bool Deletar(SightDay1 refTime)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {

                    _context.SightDay1s.Remove(refTime);
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
        public List<SightDay1ViewModel> Listar()
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    var SightDay1View = (from a in _context.SightDay1s
                                    select new SightDay1ViewModel
                                    {
                                        Id = a.Id,
                                        DateInit = a.DateInit,
                                        PriceInit = a.PriceInit,
                                        PriceTarget = a.PriceTarget,
                                        DateEnd = a.DateEnd,
                                        PriceEnd = a.PriceEnd,

                                    }).ToList();

                    return SightDay1View;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //ListarPorId
        public SightDay1 ListarPorId(string date)
        {
            try
            {
                using (AimPointContext _context = new AimPointContext())
                {
                    return _context.SightDay1s.Where(a => a.DateInit == date).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}