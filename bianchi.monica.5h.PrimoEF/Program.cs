using System;
using System.Linq;
using bianchi.monica._5h.PrimoEF.Models;

namespace bianchi.monica._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ef World!");

            var db = new DbPersone();

            foreach(var R in db.Persone) {
                Console.WriteLine(R);
            }

            // Preleva il primo record
            // var p = db.Persone.First();

            var p = db.Persone.Max(Monica => Monica.ID);
            Console.WriteLine(p);


            db.Persone.RemoveRange(db.Persone);


            db.Persone.Add(new Persona{Nome = "Monica", Cognome = "Bianchi", Email = "monica03bianchi@gmail.com"});
            db.SaveChanges();

    
        }
    }
}
