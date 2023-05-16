using Microsoft.AspNetCore.Mvc;
using progettoconAndrea.Data;
using progettoconAndrea.Models;

namespace progettoconAndrea.Controllers
{
    public class professoriController : Controller
    {
        // va scritto perchè eredita da controller 
        // reinderizza (fai vedere/carica) una pagina ecco perchè creiamo una nuova classe
        private Database _db;
        public professoriController(Database db) { _db = db; }

        public IActionResult Index() // è un metodo della classe utenti controller. 
        {
            var model = _db.professoris.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(professori y)
        {
            _db.professoris.Add(y);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details (int id) 
        {
            var utente = _db.professoris.FirstOrDefault(x => x.id == id);
            return View(utente);
        }
    }


}

