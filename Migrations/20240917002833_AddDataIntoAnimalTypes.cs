using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API_Granja.Migrations
{
    /// <inheritdoc />
    public partial class AddDataIntoAnimalTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "animal_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "vertebrados de sangre caliente con pelo o pelaje.", "mamífero" },
                    { 2, "vertebrados emplumados y alados capaces de volar.", "ave" },
                    { 3, "vertebrados de sangre fría con escamas.", "reptil" },
                    { 4, "vertebrados de sangre fría que pasan parte de su vida en el agua y parte en tierra.", "anfibio" },
                    { 5, "vertebrados acuáticos con branquias, aletas y escamas.", "pez" },
                    { 6, "animales sin columna vertebral, incluyendo insectos, arañas y moluscos.", "invertebrado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
