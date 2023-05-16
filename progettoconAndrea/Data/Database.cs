using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using progettoconAndrea.Models;

namespace progettoconAndrea.Data
{
    public class Database : DbContext // perche stiamo creando un nuovo contesto di database (piu o meno ci connettiamo al database) 
    {
        public Database(DbContextOptions<Database>options): base(options) // opzioni
        { }
        public DbSet<Utenti> utentis { get; set; } // nome della tabella del database
        public DbSet<professori> professoris { get; set; } 
    }

   
}
