using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IPeliculaRepositorio
    {
        List<Pelicula> GetAllPeliculas();
        Pelicula? GetPeliculaPorTitulo(string titulo);
    }
}
