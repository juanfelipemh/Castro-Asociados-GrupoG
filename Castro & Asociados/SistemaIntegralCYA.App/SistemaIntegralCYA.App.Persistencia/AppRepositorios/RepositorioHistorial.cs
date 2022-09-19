using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public class RepositorioHistorial : IRepositorioHIstorial
    {
        // Acá creamos conexión con la base de datos

        // <summary>
        /// Referencia al contexto de Historial
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioHistorial(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Historial AddHistorial(Historial nuevoHistorial)
        {
            var histoialAdicional = _appContext.Historial.Add(nuevoHistorial);
            _appContext.SaveChanges();
            return histoialAdicional.Entity;
        }

        public IEnumerable<Historial> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Historial> GetHistorialPorFiltro(string filtro)
        {
            var historial = GetAll();
            if (historial != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    historial = historial.Where(s => s.DescripcionServicio.Contains(filtro));
                }
            }
            return historial;
        }

        public IEnumerable<Historial> GetAll_()
        {
            return _appContext.Historial;
        }

        public Historial GetHistorialPorId(int historialId)
        {
            return _appContext.Historial.FirstOrDefault(r => r.Id == historialId);
        }

        public Historial UpdateHistorial(Historial historialActualizado)
        {
            var historial = _appContext.Historial.FirstOrDefault(r => r.Id == historialActualizado.Id);
            if (historial != null)
            {
                historial.Horario = historialActualizado.Horario;
                historial.FechaServicio = historial.FechaServicio;
                historial.Servicio = historialActualizado.Servicio;
                historial.DescripcionServicio = historialActualizado.DescripcionServicio;
                historial.Valor = historialActualizado.Valor;                

                _appContext.SaveChanges();
            }
            return historial;

        }
    }
}