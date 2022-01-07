using System;
using Microsoft.EntityFrameworkCore;

namespace bianchi.monica._5h.PrimoEF.Models
{
    public class DbPersone : DbContext
    {
        //Tabella all'interno del database
       public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        { opzioni.UseSqlite("Data Source=dbPersone.db"); }
    }
}