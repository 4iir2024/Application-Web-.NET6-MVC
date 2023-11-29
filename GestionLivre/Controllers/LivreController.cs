using GestionLivre.Data;
using GestionLivre.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivre.Controllers
{
    public class LivreController : Controller
    {
        private static List<Livre> livres = LivreRepo.GetLivres();
        
        private static int Id = 2;

        public IActionResult Index()
        {
            ViewBag.livres = livres;
            // ViewData["livres"] = livres;
            return View();
        }

        [HttpGet]
        public IActionResult Ajouter()
        {
            
            
            Livre livre =new Livre();
            livre.Isbn = Id;
            return View(livre);
        }
        [HttpPost]
        public IActionResult Ajouter(Livre livre)
        {
            
            
            livres.Add(livre);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modifier(int id)
        {
            Livre livre = livres.Find(lv => lv.Isbn == id);

            return View(livre);
        }
        [HttpPost]
        public IActionResult Modifier(Livre livre)
        {
            Livre l = livres.Find(lv => lv.Isbn == livre.Isbn);
            l.Titre = livre.Titre;
            l.Auteur = livre.Auteur;
            l.Auteur = livre.Auteur;
            l.DateEdition = livre.DateEdition;
            l.Resume = livre.Resume;
            return RedirectToAction("Index");
        }

        public IActionResult Supprimer(int id)
        {
            Livre livre = livres.Find(lv => lv.Isbn == id);
            livres.Remove(livre);
            return RedirectToAction("Index");
        }
    }
}
