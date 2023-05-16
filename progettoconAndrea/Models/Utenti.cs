using System.ComponentModel.DataAnnotations; // perchè sto usando le key che vengono da questa classe

namespace progettoconAndrea.Models
{
    public class Utenti
    {
        [Key]
        public int Id  { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; } 

        public int Eta { get; set; }
    }
}
