using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnicos> GetAll();
        Tecnicos GetTecnicoPorId(int tecnicoId);
        Tecnicos AddTecnico (Tecnicos nuevoTecnico);
        Tecnicos UpdateTecnico (Tecnicos tecnicoActualizado);
        void DeleteTecnico (int tecnicoId);
        IEnumerable<Tecnicos> GetTecnicosPorFiltro(string filtro);
    }
}