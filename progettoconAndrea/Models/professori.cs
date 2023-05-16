using System.ComponentModel.DataAnnotations;

namespace progettoconAndrea.Models
{
    public class professori

    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string materia { get; set; }
    }
}
