using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public class PeliculaRepositorio : IPeliculaRepositorio
    {
        private readonly ApplicationDbContext _context;
        public PeliculaRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Pelicula> GetAllPeliculas()
        {
            return _context.Peliculas.ToList();
        }
        public Pelicula? GetPeliculaPorTitulo(string titulo)
        {
            return _context.Peliculas.FirstOrDefault(p => p.Titulo.Equals(titulo));
        }
    }
}
