using System.Collections.Generic;
using System.Linq;
using SICAU.App.Dominio;

namespace SICAU.App.Persistencia
{
    public class RepositorioSalon : IRepositorioSalon
    {
        private readonly AppContext _appContext;
        public IEnumerable<Salon> salones;

        public RepositorioSalon(AppContext appContext)
        {
            _appContext = appContext;
        }
        public RepositorioSalon(IEnumerable<Salon> salones)
        {
            this.salones = salones;
        }

        Salon IRepositorioSalon.AddSalon(Salon salon)
        {
            var salonAdicionado = _appContext.salones.Add(salon);
            _appContext.SaveChanges();
            return salonAdicionado.Entity;
        }

        void IRepositorioSalon.DeleteSalon(int idSalon)
        {
            var salonEncontrado = _appContext.salones.FirstOrDefault(p => p.id == idSalon);
            if (salonEncontrado == null)
                return;
            _appContext.salones.Remove(salonEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Salon> IRepositorioSalon.GetAllSalon()
        {
            return _appContext.salones;
        }

        IEnumerable<Salon> IRepositorioSalon.GetByNames(string criterio)
        {
            var salones = _appContext.salones.ToList();

            if (salones != null
            && !string.IsNullOrEmpty(criterio))
            {
                salones = _appContext.salones.Where(p => p.numero.Contains(criterio)).ToList();
            }

            foreach (Salon salon in salones)
            {
                _appContext.Entry(salon).Reference(m => m.sede).Load();
            }

            return salones;
        }

        Salon IRepositorioSalon.GetSalon(int idSalon)
        {
            return _appContext.salones.FirstOrDefault(p => p.id == idSalon);
        }

        Salon IRepositorioSalon.UpdateSalon(Salon salon)
        {
            var salonEncontrado = _appContext.salones.FirstOrDefault(p => p.id == salon.id);
            if (salonEncontrado != null)
            {
                salonEncontrado.id = salon.id;
                salonEncontrado.sede = salon.sede;
                salonEncontrado.numero = salon.numero;
                salonEncontrado.capacidad = salon.capacidad;
                _appContext.SaveChanges();
            }
            return salonEncontrado;
        }

    }
}