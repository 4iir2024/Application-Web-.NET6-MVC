using System.Data;

namespace GestionLivre.Models
{
    public class Livre
    {
        public  int Isbn { get; set; }
        public String Titre { get; set; }
        public String Auteur { get; set; }
        public DateTime DateEdition { get; set; }
        public String Resume { get; set; }
    }
}
