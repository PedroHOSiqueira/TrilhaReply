using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReplyAPI.Migrations
{
    /// <inheritdoc />
    public partial class SecondFixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioEquipe",
                table: "UsuarioEquipe",
                columns: new[] { "UsuarioId", "EquipeId" });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEquipe_EquipeId",
                table: "UsuarioEquipe",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_ProjetosId",
                table: "Tarefas",
                column: "ProjetosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Projetos_ProjetosId",
                table: "Tarefas",
                column: "ProjetosId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEquipe_Equipe_EquipeId",
                table: "UsuarioEquipe",
                column: "EquipeId",
                principalTable: "Equipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEquipe_Usuario_UsuarioId",
                table: "UsuarioEquipe",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Projetos_ProjetosId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEquipe_Equipe_EquipeId",
                table: "UsuarioEquipe");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEquipe_Usuario_UsuarioId",
                table: "UsuarioEquipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioEquipe",
                table: "UsuarioEquipe");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioEquipe_EquipeId",
                table: "UsuarioEquipe");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_ProjetosId",
                table: "Tarefas");
        }
    }
}
