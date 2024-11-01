using Aplicacion.Interfaces;
using Aplicacion.Modelos.Pelicula;
using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class PeliculaServicio : IPeliculaServicio
    {
        private readonly IPeliculaRepositorio _repositorio;
        private readonly PeliculaDto _peliculaDto;


        public PeliculaServicio(IPeliculaRepositorio repositorio, PeliculaDto peliculaDto)
        {
            _repositorio = repositorio;
            _peliculaDto = peliculaDto;
        }

        public List<PeliculaDto.PeliculaRespuesta> GetAllPelicula()
        {
            var peliculasEntidad = _repositorio.GetAllPeliculas().ToList();
            var respuesta = peliculasEntidad.Select(p => _peliculaDto.FromEntityToDto(p)).ToList();
            return respuesta;
        }
        public PeliculaDto.PeliculaRespuesta GetPeliculaPorTitulo(string titulo)
        {
            var pelicula = _repositorio.GetPeliculaPorTitulo(titulo);
            if (pelicula == null)
            {
                throw new Exception("No se encontró la pelicula");
            }
            var respuesta = _peliculaDto.FromEntityToDto(pelicula);
            return respuesta;
        }
    }
}
