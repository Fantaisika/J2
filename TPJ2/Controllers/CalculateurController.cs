using Microsoft.AspNetCore.Mvc;

namespace TPJ2.Controllers
{
    public class CalculateurController : Controller
    {
        public string Ajouter(int valeur1, int valeur2)
        {
            int res = valeur1 + valeur2;
            return res.ToString();
        }

        public string Multiplier(int valeur1, int valeur2)
        {
            int res = valeur1 * valeur2;
            return res.ToString();
        }
    }
}
