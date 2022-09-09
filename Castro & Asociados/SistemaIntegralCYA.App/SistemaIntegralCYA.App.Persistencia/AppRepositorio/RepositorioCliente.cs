using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorio
{
    public class RepositorioCliente : IRepositorioCliente
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//        
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Cliente Add(Cliente nuevoCliente)
        {
            var clienteNuevo = _appContext.Clientes.Add(nuevoCliente);
            _appContext.SaveChanges();
            return clienteNuevo.Entity;
        }
    }
}