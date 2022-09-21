using System.Collections.Generic;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetClientePorId(int clienteId);
        Cliente UpdateUsuario(Cliente ClienteActualizado);
        void DeleteUsuario (int clienteId);
        Cliente AddUsuario(Cliente NuevoCliente);
        IEnumerable<Cliente> GetClientePorFiltro(string filtro);
        Tecnicos AsignarTecnico (int clienteId, int tecnicoId);
    }
}