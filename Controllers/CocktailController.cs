using Microsoft.AspNetCore.Mvc;
using Najžer_RST_MAG_RNSUV_Projektna.Data;
using Najžer_RST_MAG_RNSUV_Projektna.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Controllers
{
    public class CocktailController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CocktailController(ApplicationDbContext db)
        {
            _db = db;
        }

        //  Prikaz koktejlov
        public IActionResult Index()
        {
            IEnumerable<CocktailModel> objList = _db.Cocktail;
            return View(objList);
        }

        //  Dodajanje koktejlov GET - ADD
        public IActionResult Add()
        {
            return View();
        }

        //  Dodajanje koktejlov POST - ADD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CocktailModel obj)
        {
            //  Validacija
            if (ModelState.IsValid)
            {
                _db.Cocktail.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "CocktailManager");
            }
            return View(obj);
        }

        //  Urejanje koktejlov GET - EDIT
        public IActionResult Edit(int id)
        {
            var obj = _db.Cocktail.Find(id);
            return View(obj);
        }

        //  Urejanje koktejlov POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CocktailModel obj)
        {
            //  Validacija
            if (ModelState.IsValid)
            {
                _db.Cocktail.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "CocktailManager");
            }
            return View(obj);
        }

        //  Odstranjevanje koktejlov GET - DELETE
        public IActionResult Delete(int id)
        {
            var obj = _db.Cocktail.Find(id);
            return View(obj);
        }

        //  Odstranjevanje koktejlov POST - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CocktailModel obj)
        {
            _db.Cocktail.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "CocktailManager");
        }
    }
}
