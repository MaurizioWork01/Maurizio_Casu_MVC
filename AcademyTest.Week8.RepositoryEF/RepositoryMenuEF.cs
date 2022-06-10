using AcademyTest.Week8.Core.Entities;
using AcademyTest.Week8.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.RepositoryEF
{
    public class RepositoryMenuEF : IRepositoryMenu
    {
        public Menu Add(Menu item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Menu.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Menu item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Menu.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Menu> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Menu.Include(m => m.Piatti).ToList();
            }
        }

        public Menu GetByCode(string codice)
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Menu.Include(m => m.Piatti).FirstOrDefault(m => m.CodiceMenu == codice);
            }
            
        }

        public Menu Update(Menu item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Menu.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
