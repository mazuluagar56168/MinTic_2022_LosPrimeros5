using System.Collections.Generic;
using SICAU.App.Dominio;

namespace SICAU.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSede();
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);
    }
}