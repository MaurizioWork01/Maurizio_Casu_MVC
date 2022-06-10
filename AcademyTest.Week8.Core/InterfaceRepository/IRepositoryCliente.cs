using AcademyTest.Week8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.InterfaceRepository
{
    public interface IRepositoryCliente : IRepository<Cliente>
    {
        Cliente GetById (int id);
    }
}
