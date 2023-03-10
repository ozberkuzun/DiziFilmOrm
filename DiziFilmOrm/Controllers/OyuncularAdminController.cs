using DiziFilmData.Data;
using DiziFilmModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiziFilmOrm.Controllers
{
    public class OyuncularAdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OyuncularAdminController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var objList = _db.Oyuncular.ToList();
            return View(objList);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Oyuncular obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var ob = await _db.Oyuncular.FindAsync(id);
            return View(ob);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Oyuncular ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ob);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Oyuncular.FindAsync(id);
            return View(obj);
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Oyuncular.FindAsync(id);
            _db.Oyuncular.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
