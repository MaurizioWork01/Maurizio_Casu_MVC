using AcademyTest.Week8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Menu
        List<Menu> GetAllMenu();
        Esito AggiungiMenu(Menu nuovoMenu);
        Esito ModificaMenu(string? codice, string? nuovoNome);
        Esito EliminaMenu(string? codice);

        #endregion

        #region Piatto
        List<Piatto> GetAllPiatti();
        Esito InserisciNuovoPiatto(Piatto nuovoPiatto);
        Esito ModificaPiatto(int idPiattoDaModificare, string? nuovaEmail);
        Esito EliminaPiatto(int idPiattoeDaEliminare);
        List<Piatto> GetPiattiByMenuCodice(string? codiceMenu);

        #endregion

    }
}
