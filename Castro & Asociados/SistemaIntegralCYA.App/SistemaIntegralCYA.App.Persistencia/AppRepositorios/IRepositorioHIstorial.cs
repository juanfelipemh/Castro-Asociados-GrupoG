using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHIstorial
    {
        IEnumerable<Historial> GetAll();
        Historial GetHistorialPorId(int historialId);
        Historial AddHistorial(Historial nuevoHistorial);
        Historial UpdateHistorial(Historial historialActualizado);
        IEnumerable<Historial> GetHistorialPorFiltro(string filtro);
        
    }
}