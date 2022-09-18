using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaIntegralCYA.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SistemaIntegralCYA.App.Persistencia.AppRepositorios
{
    public class RepositorioTecnico : IRepositorioTecnico
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

        public RepositorioTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Tecnicos AddTecnico (Tecnicos nuevoTecnico)
        {
            var tecnicoAdicional = _appContext.Tecnicos.Add(nuevoTecnico);
            _appContext.SaveChanges();
            return tecnicoAdicional.Entity;
        }

        public IEnumerable<Tecnicos> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Tecnicos> GetTecnicosPorFiltro(string filtro)
        {
            var tecnicos = GetAll();
            if(tecnicos != null)
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    tecnicos = tecnicos.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return tecnicos;
        }

        public IEnumerable<Tecnicos> GetAll_()
        {
            return _appContext.Tecnicos;
        }

        public Tecnicos GetTecnicoPorId(int tecnicoId)
        {
            return _appContext.Tecnicos.FirstOrDefault(r => r.Id == tecnicoId);
        }

        public Tecnicos UpdateTecnico (Tecnicos tecnicoActualizado)
        {
            var tecnico = _appContext.Tecnicos.FirstOrDefault(r => r.Id == tecnicoActualizado.Id);
            if(tecnico != null)
            {
                tecnico.Nombre = tecnicoActualizado.Nombre;
                tecnico.Apellido = tecnicoActualizado.Apellido;
                tecnico.NumeroTelefono = tecnicoActualizado.NumeroTelefono;
                tecnico.CorreoElectronico = tecnicoActualizado.CorreoElectronico;
                tecnico.ClaveUsuario = tecnicoActualizado.ClaveUsuario;
                tecnico.TarjetaProfesional = tecnicoActualizado.TarjetaProfesional;

                _appContext.SaveChanges();
            }
            return tecnico;

        }
    }
}