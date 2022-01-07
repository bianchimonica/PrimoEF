using System.ComponentModel.DataAnnotations;

namespace bianchi.monica._5h.PrimoEF.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{ID}\t{Nome}\t{Cognome}\t{Email}";
        }

    }
}