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
    public class RepositoryPiattoEF : IRepositoryPiatto
    {
        public Piatto Add(Piatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Piatti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Piatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Piatti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Piatto> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Piatti.Include(p => p.Menu).ToList();
            }
        }

        public Piatto GetPiattoById(int id)
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Piatti.Include(p => p.Menu).FirstOrDefault(p => p.Id == id);
            }
        }

        public Piatto Update(Piatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Piatti.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
