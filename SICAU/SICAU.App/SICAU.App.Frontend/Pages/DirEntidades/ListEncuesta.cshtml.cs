using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SICAU.App.Dominio;
using SICAU.App.Persistencia;

namespace SICAU.App.Frontend.Pages
{
    public class ListEncuestaModel : PageModel
    {
        public IRepositorioEncuestaCovid _repositorioEncuestaCovid = new RepositorioEncuestaCovid(new Persistencia.AppContext());
        public IEnumerable<EncuestaCovid> encuestaCovids{ get; set; }
        public string criterio;
        public void OnGet(DateTime criterio)
        {
            encuestaCovids = _repositorioEncuestaCovid.GetByDate(criterio);
        }
    }
}
