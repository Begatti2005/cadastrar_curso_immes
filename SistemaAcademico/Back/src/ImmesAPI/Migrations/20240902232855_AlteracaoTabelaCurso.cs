using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoTabelaCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CursoSet",
                table: "CursoSet");

            migrationBuilder.RenameTable(
                name: "CursoSet",
                newName: "TAB_Curso");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TAB_Curso",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_Curso",
                table: "TAB_Curso",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_Curso",
                table: "TAB_Curso");

            migrationBuilder.RenameTable(
                name: "TAB_Curso",
                newName: "CursoSet");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "CursoSet",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursoSet",
                table: "CursoSet",
                column: "Id");
        }
    }
}
