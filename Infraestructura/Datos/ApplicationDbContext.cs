using Dominio.Entidades;
using Dominio.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(ActorDataSeed());
            modelBuilder.Entity<Pelicula>().HasData(PeliculaDataSeed());
        }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        private Actor[] ActorDataSeed()
        {
            Actor[] actores;
            actores = [
                new Actor{
                    Id = 1,
                    Nombre = "Ricardo Darín",
                    PaisNacimiento = Nacionalidad.Argentina
                },
                new Actor {
                    Id = 2,
                    Nombre = "Antonio Banderas",
                    PaisNacimiento = Nacionalidad.España
                },
                new Actor {
                    Id=3,
                    Nombre = "Jack Nicholson"
                }
              ];
            return actores;
        }
        private Pelicula[] PeliculaDataSeed()
        {
            Pelicula[] peliculas;
            peliculas = [
                new Pelicula{
                    Id = 1,
                    Titulo = "El Padrino",
                    Descripcion = "En el verano de 1945, se celebra la boda de Connie (Talia Shire) y Carlo Rizzi (Gianni Russo). Connie es la única hija de Don Vito Corleone (Marlon Brando), jefe de una de las familias que ejercen el mando de la Cosa Nostra en la ciudad de Nueva York. Don Vito además tiene otros tres hijos: su primogénito Sonny (James Caan), el endeble Fredo ."
                },
                new Pelicula {
                    Id = 2,
                    Titulo = "Cadena Perpetua",
                    Descripcion = "En 1947, Andy Dufresne (Tim Robbins), un joven banquero, es condenado a cadena perpetua por asesinar a su esposa y su amante. A pesar de declararse inocente, es encarcelado en Shawshank, el penitenciario más duro del estado de Maine. Allí se encontrará con Red Redding (Morgan Freeman), un hombre desilusionado, encarcelado desde hace más de ..."
                },
                new Pelicula {
                    Id=3,
                    Titulo = "La vida es bella",
                    Descripcion = "La Segunda Guerra Mundial está a punto de estallar en Europa. Mientras tanto, Guido llega a un pueblo italiano con la intención de abrir una librería. Allí se enamora de la novia de un fascista italiano, Dora. Ésta sucumbirá a sus encantos y Guido consigue que se case con él. De la bonita unión nace un pequeño que tendrá que vivir en ..."
                }
              ];
            return peliculas;
        }
    }
}
