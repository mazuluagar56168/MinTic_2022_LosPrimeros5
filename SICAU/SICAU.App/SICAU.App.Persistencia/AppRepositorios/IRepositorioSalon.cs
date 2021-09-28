using System.Collections.Generic;
using SICAU.App.Dominio;

namespace SICAU.App.Persistencia
{
    public interface IRepositorioSalon
    {
        IEnumerable<Salon> GetAllSalon();
        IEnumerable<Salon> GetByNames(string criterio);
        Salon AddSalon(Salon salon);
        Salon UpdateSalon(Salon salon);
        void DeleteSalon(int idSalon);
        Salon GetSalon(int idSalon);
    }
}