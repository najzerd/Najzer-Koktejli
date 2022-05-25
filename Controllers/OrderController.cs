using Microsoft.AspNetCore.Mvc;
using Najžer_RST_MAG_RNSUV_Projektna.Data;
using Najžer_RST_MAG_RNSUV_Projektna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<OrderModel> objList = _db.Order;
            return View(objList);
        }

        //  Dodajanje naročilo GET - ADD
        public IActionResult Add(int id)
        {
            var obj = _db.Cocktail.Find(id);
            return View(obj);
        }

        //  Dodajanje naročilo POST - ADD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(OrderModel obj)
        {
            //  Validacija
            if (ModelState.IsValid)
            {
                _db.Order.Add(obj);
                _db.SaveChanges();
                return View("Ordered");
            }
            return View(obj);
        }

        public IActionResult Clear()
        {
            foreach(var obj in _db.Order)
            {
                _db.Order.Remove(obj);
            }
            _db.SaveChanges();
            return View("Clear");
        }
    }
}
