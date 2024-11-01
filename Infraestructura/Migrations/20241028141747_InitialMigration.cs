using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    PaisNacimiento = table.Column<int>(type: "INTEGER", nullable: true),
                    PeliculaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actores_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Nombre", "PaisNacimiento", "PeliculaId" },
                values: new object[,]
                {
                    { 1, "Ricardo Darín", 0, null },
                    { 2, "Antonio Banderas", 1, null },
                    { 3, "Jack Nicholson", null, null }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "Descripcion", "Titulo" },
                values: new object[,]
                {
                    { 1, "En el verano de 1945, se celebra la boda de Connie (Talia Shire) y Carlo Rizzi (Gianni Russo). Connie es la única hija de Don Vito Corleone (Marlon Brando), jefe de una de las familias que ejercen el mando de la Cosa Nostra en la ciudad de Nueva York. Don Vito además tiene otros tres hijos: su primogénito Sonny (James Caan), el endeble Fredo .", "El Padrino" },
                    { 2, "En 1947, Andy Dufresne (Tim Robbins), un joven banquero, es condenado a cadena perpetua por asesinar a su esposa y su amante. A pesar de declararse inocente, es encarcelado en Shawshank, el penitenciario más duro del estado de Maine. Allí se encontrará con Red Redding (Morgan Freeman), un hombre desilusionado, encarcelado desde hace más de ...", "Cadena Perpetua" },
                    { 3, "La Segunda Guerra Mundial está a punto de estallar en Europa. Mientras tanto, Guido llega a un pueblo italiano con la intención de abrir una librería. Allí se enamora de la novia de un fascista italiano, Dora. Ésta sucumbirá a sus encantos y Guido consigue que se case con él. De la bonita unión nace un pequeño que tendrá que vivir en ...", "La vida es bella" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actores_PeliculaId",
                table: "Actores",
                column: "PeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actores");

            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
