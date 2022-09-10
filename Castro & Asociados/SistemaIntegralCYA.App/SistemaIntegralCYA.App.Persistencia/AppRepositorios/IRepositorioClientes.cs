using System.Collections.Generic;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAll();
    }
}