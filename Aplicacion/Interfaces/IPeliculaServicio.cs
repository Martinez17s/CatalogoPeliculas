using Aplicacion.Modelos.Pelicula;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IPeliculaServicio
    {
        List<PeliculaDto.PeliculaRespuesta> GetAllPelicula();
        PeliculaDto.PeliculaRespuesta GetPeliculaPorTitulo(string titulo);
    }
}
