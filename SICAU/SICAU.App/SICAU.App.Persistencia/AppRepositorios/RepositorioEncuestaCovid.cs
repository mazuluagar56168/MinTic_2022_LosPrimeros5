using System.Collections.Generic;
using SICAU.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace SICAU.App.Persistencia
{
    public class RepositorioEncuestaCovid : IRepositorioEncuestaCovid
    {
        private readonly AppContext _appContext;

        public IEnumerable<EncuestaCovid> encuestaCovids;

        public RepositorioEncuestaCovid(AppContext appContext)
        {
            _appContext = appContext;
        }

        public RepositorioEncuestaCovid(IEnumerable<EncuestaCovid> encuestaCovids)
        {
            this.encuestaCovids = encuestaCovids;
        }
        EncuestaCovid IRepositorioEncuestaCovid.AddEncuestaCovid(EncuestaCovid encuestaCovid)
        {
            var encuestaCovidAdicionado = _appContext.encuestaCovids.Add(encuestaCovid);
            _appContext.SaveChanges();
            return encuestaCovidAdicionado.Entity;
        }

        void IRepositorioEncuestaCovid.DeleteEncuestaCovid(int idEncuestaCovid)
        {
            var encuestaCovidEncontrado = _appContext.encuestaCovids.FirstOrDefault(p => p.id == idEncuestaCovid);
            if (encuestaCovidEncontrado == null)
                return;
            _appContext.encuestaCovids.Remove(encuestaCovidEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<EncuestaCovid> IRepositorioEncuestaCovid.GetAllEncuestaCovid()
        {
            var encuestas = _appContext.encuestaCovids.ToList();
            foreach (EncuestaCovid encuesta in encuestas)
            {
                _appContext.Entry(encuesta).Reference(p => p.persona).Load();
            }
            return encuestas;
        }

        EncuestaCovid IRepositorioEncuestaCovid.GetEncuestaCovid(int idEncuestaCovid)
        {
            EncuestaCovid encuestaCovid = _appContext.encuestaCovids.FirstOrDefault(p => p.id == idEncuestaCovid);
            _appContext.Entry(encuestaCovid).Reference(p => p.persona).Load();
            return encuestaCovid;
        }

        IEnumerable<EncuestaCovid> IRepositorioEncuestaCovid.GetByDate(DateTime criterio)
        {
            var encuestaCovids = _appContext.encuestaCovids.ToList();

            if (encuestaCovids != null
            && criterio > DateTime.Parse("2020-01-01"))
            {
                encuestaCovids = _appContext.encuestaCovids.Where(p => p.fechaEncuesta.Equals(criterio) || p.fechaDiagnostico.Equals(criterio)).ToList();
            }
            foreach(EncuestaCovid encuestaCovid in encuestaCovids)
            {
                _appContext.Entry(encuestaCovid).Reference(p => p.persona).Load();
            }
            return encuestaCovids;
        }

        EncuestaCovid IRepositorioEncuestaCovid.UpdateEncuestaCovid(EncuestaCovid encuestaCovid)
        {
            var encuestaCovidEncontrado = _appContext.encuestaCovids.FirstOrDefault(p => p.id == encuestaCovid.id);
            if (encuestaCovidEncontrado != null)
            {
                encuestaCovidEncontrado.id = encuestaCovid.id;
                encuestaCovidEncontrado.fechaEncuesta = encuestaCovid.fechaEncuesta;
                encuestaCovidEncontrado.estadoCovid = encuestaCovid.estadoCovid;
                encuestaCovidEncontrado.fechaDiagnostico = encuestaCovid.fechaDiagnostico;
                encuestaCovidEncontrado.persona = encuestaCovid.persona;
                _appContext.SaveChanges();

                foreach (var entity in _appContext.ChangeTracker.Entries())
                {
                    entity.State = EntityState.Detached;
                }
            }
            return encuestaCovidEncontrado;
        }

        public EncuestaCovid AsignarPersona(int idEncuestaCovid, int idPersona)
        {
            EncuestaCovid encuestaCovid = _appContext.encuestaCovids.FirstOrDefault(e => e.id == idEncuestaCovid);
            Persona persona = _appContext.personas.FirstOrDefault(p => p.id == idPersona);
            encuestaCovid.persona = persona;
            _appContext.SaveChanges();

            return encuestaCovid;
        }
    }
}