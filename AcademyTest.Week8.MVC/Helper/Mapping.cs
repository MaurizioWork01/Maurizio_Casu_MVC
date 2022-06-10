using AcademyTest.Week8.Core.Entities;
using AcademyTest.Week8.MVC.Models;

namespace AcademyTest.Week8.MVC.Helper
{
    public static class Mapping
    {
        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            List<PiattoViewModel> piattiViewModel = new List<PiattoViewModel>();
            foreach (var item in menu.Piatti)
            {
                piattiViewModel.Add(item?.ToPiattoViewModel());
            }

            return new MenuViewModel
            {
                CodiceMenu = menu.CodiceMenu,
                NomeMenu = menu.NomeMenu,
                Piatti = piattiViewModel

            };
        }


    }
}
