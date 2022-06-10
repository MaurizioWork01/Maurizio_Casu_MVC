using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.Entities
{
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Tipologia { get; set; }
        public decimal Prezzo { get; set; }

        //fk
        public string CodiceMenu { get; set; }
        public Menu Menu { get; set; }


        public override string ToString()
        {
            return $"{Nome}\t{Descrizione}\t{Tipologia}\t{Prezzo}";
        }


    }
}
