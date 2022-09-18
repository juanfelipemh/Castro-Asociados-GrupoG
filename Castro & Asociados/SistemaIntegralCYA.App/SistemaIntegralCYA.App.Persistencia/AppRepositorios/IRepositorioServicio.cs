using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioServicio
    {
        IEnumerable<Servicio> GetAll();
        Servicio GetServicioPorId(int servicioId);
        Servicio AddServicio(Servicio nuevoServicio);
        Servicio UpdateServicio(Servicio servicioActualizado);
        IEnumerable<Servicio> GetServiciosPorFiltro(string filtro);
    }
}