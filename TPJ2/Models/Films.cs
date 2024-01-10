using System.Collections.Generic;

namespace TPJ2.Models
{
    public static class Films
    {
        public static List<Film> getFilms()
        {
            return new List<Film>()
            {
                new Film(){Titre="Titanic",Année=1999,Realisateur="James cameron", Visionne=true},
                new Film(){Titre="John Wick 17",Année=2032,Realisateur="Unknown", Visionne=false},
                new Film(){Titre="Titanic2",Année=2020,Realisateur="James cameron", Visionne=true},
                new Film(){Titre="Titanic3 le retour du capitaine maudit",Année=2021,Realisateur="James cameron", Visionne=false},
            };
        }
    }
}
