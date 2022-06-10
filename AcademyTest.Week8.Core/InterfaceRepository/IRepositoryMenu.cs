using AcademyTest.Week8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.InterfaceRepository
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Menu GetByCode(string codice);
    }
}
