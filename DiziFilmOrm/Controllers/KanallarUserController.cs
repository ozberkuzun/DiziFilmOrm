using DiziFilmData.Data;
using DiziFilmModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiziFilmOrm.Controllers
{
    public class KanallarUserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public KanallarUserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Kanallar> kanallar = _db.Kanallar.ToList();
            List<Diziler> diziler = _db.Diziler.ToList();
            List<Oyuncular> oyuncular = _db.Oyuncular.ToList();
            var birlestir = from k in kanallar
                            join d in diziler on k.KanalID equals d.KanalID
                            join o in oyuncular on d.DiziID equals o.DiziID
                            into sıralamalar
                            from o in sıralamalar.DefaultIfEmpty()
                            select new joinler
                            {
                                kanallar = k,
                                diziler = d,
                                oyuncular = o
                            };
            return View(birlestir);

            //var objList = _db.Kanallar.ToList();
            //return View(objList);
        }
    }
    }