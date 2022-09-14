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
                new Cliente{Id=0,Nombre="Juan Felipe",Apellido="Muñoz Hurtado",NumeroTelefono="3196284085",CorreoElectronico="juanfelipemh@gmail.com", ClaveUsuario="12345Ge"},
                new Cliente{Id=1,Nombre="Maria Alejandra",Apellido="Sierra Rodriguez",NumeroTelefono="3136643662",CorreoElectronico="masierra772@gmail.com", ClaveUsuario="4321Ae"}
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
                cliente.Nombre = ClienteActualizado.Nombre;
                cliente.Apellido = ClienteActualizado.Apellido;
                cliente.NumeroTelefono = ClienteActualizado.NumeroTelefono;
                cliente.CorreoElectronico = ClienteActualizado.CorreoElectronico;
                cliente.ClaveUsuario = ClienteActualizado.ClaveUsuario;
            }
            return cliente;
        }

        public Cliente AddUsuario(Cliente NuevoCliente)
        {
            NuevoCliente.Id = clientes.Max(r => r.Id) + 1;
            clientes.Add(NuevoCliente);
            return NuevoCliente;
        }


        public IEnumerable<Cliente> GetClientePorFiltro(string filtro)
        {
            var clientes = GetAll(); // Obtiene todos los saludos
            if (clientes != null) //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    clientes = clientes.Where(c => c.id.Contains(filtro));
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>     
                }
            }
            return clientes;
        }
    }
}