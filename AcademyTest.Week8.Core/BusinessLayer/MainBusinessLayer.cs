using AcademyTest.Week8.Core.Entities;
using AcademyTest.Week8.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryMenu menuRepo;
        private readonly IRepositoryPiatto piattoRepo;


        public MainBusinessLayer(IRepositoryMenu menuRepo, IRepositoryPiatto piattoRepo)
        {
            this.menuRepo = menuRepo;
            this.piattoRepo = piattoRepo;
        }

        #region Menu
        public Esito AggiungiMenu(Menu nuovoMenu)
        {
            Menu menuRecuperato = menuRepo.GetByCode(nuovoMenu.CodiceMenu);
            if (menuRecuperato == null)
            {
                menuRepo.Add(nuovoMenu);
                return new Esito() { IsOk = true, Messaggio = "Corso aggiunto correttamente" };
            }
            return new Esito() { IsOk = false, Messaggio = "Impossibile aggiungere menu, codice già esistente" };
        }

        public Esito EliminaMenu(string? codice)
        {
            Menu menuRecuperato = menuRepo.GetByCode(codice);
            if (menuRecuperato == null)
            {
                return new Esito() { IsOk = false, Messaggio = "Nessun menu corrispondente al codice inserito" };
            }
            menuRepo.Delete(menuRecuperato);
            return new Esito() { IsOk = true, Messaggio = "Menu eliminato correttamente" };
        }
        public List<Menu> GetAllMenu()
        {
            return menuRepo.GetAll();
        }
        public Esito ModificaMenu(string? codice, string? nuovoNome)
        {
            var menuRecuperato = menuRepo.GetByCode(codice);
            if (menuRecuperato == null)
            {
                return new Esito() { IsOk = false, Messaggio = "Nessun menu corrispondente al codice inserito" };
            }
            menuRecuperato.NomeMenu = nuovoNome;
            menuRepo.Update(menuRecuperato);
            return new Esito() { IsOk = true, Messaggio = "Menu aggiornato correttamente" };
        }

        #endregion
        public List<Piatto> GetAllPiatti()
        {
            return piattoRepo.GetAll();
        }

        public Esito EliminaPiatto(int idPiattoeDaEliminare)
        {
            var piattoEsistente = piattoRepo.GetPiattoById(idPiattoeDaEliminare);
            if (piattoEsistente == null)
            {
                return new Esito() { IsOk = false, Messaggio = "Nessun piatto corrispondente al codice inserito" };
            }
            piattoRepo.Delete(piattoEsistente);
            return new Esito() { IsOk = true, Messaggio = "Piatto eliminato correttamente" };
        }



        public List<Piatto> GetPiattiByMenuCodice(string? codiceMenu)
        {
            throw new NotImplementedException();
        }

        public Esito InserisciNuovoPiatto(Piatto nuovoPiatto)
        {
            throw new NotImplementedException();
        }


        public Esito ModificaPiatto(int idPiattoDaModificare, string? nuovaEmail)
        {
            throw new NotImplementedException();
        }
    }
}
