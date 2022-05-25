using Microsoft.AspNetCore.Mvc;
using Najžer_RST_MAG_RNSUV_Projektna.Data;
using Najžer_RST_MAG_RNSUV_Projektna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Controllers
{
    public class CocktailManagerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CocktailManagerController(ApplicationDbContext db)
        {
            _db = db;
        }

        //  Prikaz koktejlov
        public IActionResult Index()
        {
            IEnumerable<CocktailModel> objList = _db.Cocktail;
            return View(objList);
        }
    }
}
