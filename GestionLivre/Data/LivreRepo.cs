using GestionLivre.Models;

namespace GestionLivre.Data
{
    public class LivreRepo
    {

        private static List<Livre> livres = new List<Livre>
        {
            new Livre
            {
                Isbn=1,
                Titre="Java",
                Auteur="Idalen",
                DateEdition=new DateTime(2023,03,11),
                Resume="Cour-TP"
            }
        };
        public static List<Livre> GetLivres() { return livres; }
    }
}
