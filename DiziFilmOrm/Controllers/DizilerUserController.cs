using DiziFilmData.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiziFilmOrm.Controllers
{
    public class DizilerUserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DizilerUserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objList = _db.Diziler.ToList();
            return View(objList);
        }
    }
}
