using Microsoft.AspNetCore.Mvc;
using progettoconAndrea.Data;
using progettoconAndrea.Models;

namespace progettoconAndrea.Controllers
{
    public class utentiController : Controller 
    {
        // va scritto perchè eredita da controller 
        // reinderizza (fai vedere/carica) una pagina ecco perchè creiamo una nuova classe

        private Database _db;
        public utentiController(Database db) {  _db = db; }
        public IActionResult Index(int? eta) // è un metodo della classe utenti controller. 
        {
            List<Utenti> model = new List<Utenti>();
            if (eta != null)
            {
                 model = _db.utentis.Where(z => z.Eta < eta).ToList(); // riporta una lista 
            }
            else 
            {
                 model = _db.utentis.ToList(); // riporta una lista 
            }
            //var model = _db.utentis..ToList(); // riporta una lista 
            return View(model);
        }
        public IActionResult Create() 
        {
            return View(); // questo serve solo a visualizzare la view 
        }
        [HttpPost]
        public IActionResult Create(Utenti x) 
        { 
            _db.utentis.Add(x); // serve ad aggiungere un utente
            _db.SaveChanges(); //salva l'aggiunta
            return RedirectToAction("Index"); // ti riporta all'index ossia pagina iniziale 
        }

        public IActionResult Delete(int id ) 
        {
            var utente = _db.utentis.FirstOrDefault(x => x.Id == id);
            _db.utentis.Remove(utente);
            _db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public IActionResult Details(int id)
        { 
            var utente = _db.utentis.FirstOrDefault(x => x.Id == id);
            return View(utente);
        }
    }

    
}
