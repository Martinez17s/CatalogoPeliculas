using Aplicacion.Interfaces;
using Aplicacion.Modelos.Pelicula;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoPeliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaServicio _servicio;
        public PeliculaController(IPeliculaServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public IActionResult GetAllPeliculas()
        {
            return Ok(_servicio.GetAllPelicula());
        }

        [HttpGet]
        public IActionResult GetPeliculaporNombre([FromRoute] string titulo)
        {
            return Ok(_servicio.GetPeliculaPorTitulo(titulo));
        }



    }
}
