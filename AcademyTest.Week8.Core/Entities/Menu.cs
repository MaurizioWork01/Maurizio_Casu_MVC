using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.Entities
{
    public class Menu
    {
        public string CodiceMenu { get; set; }
        public string NomeMenu { get; set; }
        
        //fk
        public ICollection<Piatto> Piatti { get; set; } = new List<Piatto>();
    }
}
