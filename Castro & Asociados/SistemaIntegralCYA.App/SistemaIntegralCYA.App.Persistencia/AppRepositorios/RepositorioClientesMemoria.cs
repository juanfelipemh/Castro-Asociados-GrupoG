using System;
using System.Collections.Generic;
using System.Linq;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public class RepositorioClientesMemoria : IRepositorioClientes
    {
        List<Cliente> clientes;

        public RepositorioClientesMemoria()
        {
            clientes = new List<Cliente>()
            {
                new Cliente{Id=1037626843,Nombre="Juan Felipe",Apellido="Muñoz Hurtado",NumeroTelefono="3196284085",CorreoElectronico="juanfelipemh@gmail.com", ClaveUsuario="12345Ge"},
                new Cliente{Id=1032261366,Nombre="Maria Alejandra",Apellido="Sierra Rodriguez",NumeroTelefono="3136643662",CorreoElectronico="masierra772@gmail.com", ClaveUsuario="4321Ae"}
            };
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }

        public Cliente GetClientePorId(int clienteId)
        {
            return clientes.SingleOrDefault(c => c.Id == clienteId);
        }

        public Cliente UpdateUsuario(Cliente ClienteActualizado)
        {
            var cliente = clientes.SingleOrDefault(r => r.Id == ClienteActualizado.Id);
            if (cliente != null)
            {
                cliente.Id = ClienteActualizado.Id;
                cliente.Nombre = ClienteActualizado.Nombre;
                cliente.Apellido = ClienteActualizado.Apellido;
                cliente.NumeroTelefono = ClienteActualizado.NumeroTelefono;
                cliente.CorreoElectronico = ClienteActualizado.CorreoElectronico;
                cliente.ClaveUsuario = ClienteActualizado.ClaveUsuario;
            }
            return cliente;
        }
    }
}