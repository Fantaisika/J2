using Microsoft.AspNetCore.Mvc;
using TPJ2.Models;
using System.Linq;

namespace TPJ2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return View("Error");
            }
            else
            {
                ViewData["Titre"] = id;
                return View();
            }
        }

        public IActionResult ListeFilms()
        {
            ViewData["Films"] = Films.getFilms();
            return View();
        }

        public IActionResult ChercheFilm(string id)
        {
            ViewData["Titre"] = id;

            Film film = Films.getFilms().FirstOrDefault(c => c.Titre == id);

            if (film != null)
            {
                if (film.Visionne == true)
                {
                    ViewData["Titre"] = film.Titre;
                    ViewData["Année"] = film.Année;
                    ViewData["Realisateur"] = film.Realisateur;
                    ViewData["Visionne"] = film.Visionne;
                    return View("Visionne");
                }
                else
                {
                    ViewData["Titre"] = film.Titre;
                    ViewData["Visionne"] = film.Visionne;
                    return View("AVisionner");
                }
            }

            return View("NonVisionne");
        }
    }
}
