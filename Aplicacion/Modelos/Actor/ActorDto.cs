using Dominio.Enum;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Modelos.Actor
{
    public class ActorDto
    {
        public class ActorSolicitud
        {
            public string? Nombre { get; set; }
            public Nacionalidad? PaisNacimiento { get; set; }
        }
        public class ActorRespuesta
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }
            public string? PaisNacimiento { get; set; }
        }

        public Dominio.Entidades.Actor FromDtoToEntity(ActorSolicitud dto)
        {
            return new Dominio.Entidades.Actor
            {
                Nombre = dto.Nombre,
                PaisNacimiento = dto.PaisNacimiento,
            };
        }
        public ActorRespuesta FromEntityToDto(Dominio.Entidades.Actor entity)
        {
            return new ActorRespuesta
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                PaisNacimiento = entity.PaisNacimiento.ToString()
            };
        }
    }
}
