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
                new Cliente{Id=0,Nombre="Juan Felipe",Apellido="Muñoz Hurtado",NumeroTelefono="3196284085",CorreoElectronico="juanfelipemh@gmail.com"},
                new Cliente{Id=1,Nombre="Maria Alejandra",Apellido="Sierra Rodriguez",NumeroTelefono="3136643662",CorreoElectronico="masierra772@gmail.com"}
            };
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }
    }
}