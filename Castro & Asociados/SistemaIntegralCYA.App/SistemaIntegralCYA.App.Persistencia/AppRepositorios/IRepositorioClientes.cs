using System.Collections.Generic;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetClientePorId(int clienteId);
        Cliente UpdateUsuario(Cliente ClienteActualizado);
        Cliente AddUsuario(Cliente NuevoCliente);

    }
}