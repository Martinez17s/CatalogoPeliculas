using Aplicacion.Modelos.Actor;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Modelos.Pelicula
{
    public class PeliculaDto
    {
        public class PeliculaSolicitud
        {
            public string? Titulo { get; set; }
            public string? Descripcion { get; set; }
        }
        public class PeliculaRespuesta
        {
            public int Id { get; set; }
            public string? Titulo { get; set; }
            public string? Descripcion { get; set; }
            public List<ActorDto.ActorRespuesta> Reparto { get; set; } = new List<ActorDto.ActorRespuesta>();
        }
        public Dominio.Entidades.Pelicula FromDtoToEntity(PeliculaSolicitud solicitud)
        {
            return new Dominio.Entidades.Pelicula
            {
                Titulo = solicitud.Titulo,
                Descripcion = solicitud.Descripcion,
            };
        }
        public PeliculaRespuesta FromEntityToDto(Dominio.Entidades.Pelicula entidad)
        {
            var actorMapeo = new ActorDto();
            return new PeliculaRespuesta
            {
                Id = entidad.Id,
                Titulo = entidad.Titulo,
                Descripcion = entidad.Descripcion,
                Reparto = entidad.Reparto.Select(r => actorMapeo.FromEntityToDto(r)).ToList(),
            };
        }
    }
}
