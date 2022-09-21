using System;
using System.Collections.Generic;
using System.Linq;
using SistemaIntegralCYA.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public class RepositorioClientesMemoria : IRepositorioClientes
    {
        // Acá creamos conexión con la base de datos

        // <summary>
        /// Referencia al contexto de Cliente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioClientesMemoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Cliente AddUsuario(Cliente NuevoCliente)
        {
            var cilenteAdicional = _appContext.Clientes.Add(NuevoCliente);
            _appContext.SaveChanges();
            return cilenteAdicional.Entity;
        }

        void IRepositorioClientes.DeleteUsuario (int clienteId)
        {
            var usuarioEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id ==clienteId);
            if(usuarioEncontrado == null)
                return;
            _appContext.Clientes.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Cliente> GetClientePorFiltro(string filtro)
        { 
            var clientes = GetAll();
            if(clientes != null)
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    clientes = clientes.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return clientes;
        }

        public IEnumerable<Cliente> GetAll_()
        {
            return _appContext.Clientes;
        }

        public Cliente GetClientePorId(int clienteId)
        {
            return _appContext.Clientes.FirstOrDefault(p => p.Id == clienteId);
        }       

        public Cliente UpdateUsuario(Cliente ClienteActualizado)
        {
            var cliente = _appContext.Clientes.FirstOrDefault(r => r.Id == ClienteActualizado.Id);
            if (cliente != null)
            {
                cliente.Nombre = ClienteActualizado.Nombre;
                cliente.Apellido = ClienteActualizado.Apellido;
                cliente.NumeroTelefono = ClienteActualizado.NumeroTelefono;
                cliente.CorreoElectronico = ClienteActualizado.CorreoElectronico;
                cliente.ClaveUsuario = ClienteActualizado.ClaveUsuario;                

                _appContext.SaveChanges();
            }
            return cliente;  
        }

        
        
        public Tecnicos AsignarTecnico (int clienteId, int tecnicoId)
        {
            var cliente = _appContext.Clientes.FirstOrDefault(c => c.Id == clienteId);
            if (cliente != null)
            {
                var tecnico = _appContext.Tecnicos.FirstOrDefault(r => r.Id == tecnicoId);
                if (tecnico != null)
                {
                    cliente.Tecnico = tecnico;
                    _appContext.SaveChanges();
                }
                return tecnico;
            }
            return null;
        }
        


        /* Todo lo siguiente funciona como datos de memoria para comprobar que funcione la conexión
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
                    clientes = clientes.Where(c => c.CorreoElectronico.Contains(filtro));
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>     
                }
            }
            return clientes;
        }*/
    }
}