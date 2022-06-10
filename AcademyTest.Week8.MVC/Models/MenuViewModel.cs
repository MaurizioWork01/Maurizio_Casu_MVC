using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AcademyTest.Week8.MVC.Models
{
    public class MenuViewModel
    {
        [DisplayName("Codice Menu")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public string CodiceMenu { get; set; }
        [Required]
        public string NomeMenu { get; set; }

        //fk
        public ICollection<PiattoViewModel> Piatti { get; set; } = new List<PiattoViewModel>();

    }
}
