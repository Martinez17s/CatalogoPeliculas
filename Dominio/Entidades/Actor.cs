using Dominio.Enum;

namespace Dominio.Entidades
{
    internal class Actor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public Nacionalidad? PaisNacimiento { get; set; }
    }
}