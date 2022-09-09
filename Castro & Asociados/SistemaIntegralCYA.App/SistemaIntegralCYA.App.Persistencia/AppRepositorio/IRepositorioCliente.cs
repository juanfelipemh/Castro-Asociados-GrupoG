using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorio
{
    public interface IRepositorioCliente
    {
        Cliente Add(Cliente nuevoCliente);
    }
}