using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio : IRepositorioServicio
    {
        // Acá creamos conexión con la base de datos

        // <summary>
        /// Referencia al contexto de Servicio
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioServicio(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Servicio AddServicio(Servicio nuevoServicio)
        {
            var servicioAdicional = _appContext.Servicios.Add(nuevoServicio);
            _appContext.SaveChanges();
            return servicioAdicional.Entity;
        }

        public IEnumerable<Servicio> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Servicio> GetServiciosPorFiltro(string filtro)
        {
            var servicios = GetAll();
            if(servicios != null)
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    servicios = servicios.Where(s => s.Descripcion.Contains(filtro));
                }
            }
            return servicios;
        }

        public IEnumerable<Servicio> GetAll_()
        {
            return _appContext.Servicios;
        }

        public Servicio GetServicioPorId(int servicioId)
        {
            return _appContext.Servicios.FirstOrDefault(r => r.Id == servicioId);
        }

        public Servicio UpdateServicio(Servicio servicioActualizado)
        {
            var servicio = _appContext.Servicios.FirstOrDefault(r => r.Id == servicioActualizado.Id);
            if(servicio != null)            {
                
                servicio.Descripcion = servicioActualizado.Descripcion;
                servicio.Costo = servicioActualizado.Costo;

                _appContext.SaveChanges();
            }
            return servicio;

        }        
    }
}