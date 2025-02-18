using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReplyAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "UsuarioEquipe",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdEquipe",
                table: "UsuarioEquipe",
                newName: "EquipeId");

            migrationBuilder.RenameColumn(
                name: "ProjetoId",
                table: "Tarefas",
                newName: "ProjetosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "UsuarioEquipe",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "UsuarioEquipe",
                newName: "IdEquipe");

            migrationBuilder.RenameColumn(
                name: "ProjetosId",
                table: "Tarefas",
                newName: "ProjetoId");
        }
    }
}
