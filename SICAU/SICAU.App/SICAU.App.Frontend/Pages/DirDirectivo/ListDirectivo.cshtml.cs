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
    public class ListDirectivoModel : PageModel
    {
        public IRepositorioDirectivo _repositorioDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public IEnumerable<Directivo> directivos {get;set;}

        public void OnGet()
        {
            directivos = _repositorioDirectivo.GetAllDirectivo();
        }
    }
}