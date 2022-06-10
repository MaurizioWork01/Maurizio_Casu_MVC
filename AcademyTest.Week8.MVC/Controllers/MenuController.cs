using AcademyTest.Week8.Core.BusinessLayer;
using AcademyTest.Week8.Core.Entities;
using AcademyTest.Week8.MVC.Helper;
using AcademyTest.Week8.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademyTest.Week8.MVC.Controllers
{
    public class MenuController : Controller
    {

        private readonly IBusinessLayer BL;

        public MenuController(IBusinessLayer bL)
        {
            BL = bL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Menu> menu = BL.GetAllMenu();

            List<MenuViewModel> menuViewModel = new List<MenuViewModel>();

            foreach (var item in menu)
            {
                menuViewModel.Add(item.ToMenuViewModel());
            }

            //per visualizzarli in una tabella

            return View(menuViewModel);
        }

        [HttpGet("Menu/Details/{codice}")] //Corsi/Details/id
        public IActionResult Details(string codice)
        {
            var menu = BL.GetAllMenu().FirstOrDefault(m => m.CodiceMenu == codice);
            var menuViewModel = menu.ToMenuViewModel();
            return View(menuViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
