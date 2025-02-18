using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ReplyAPI.Models
{
    public class UsuarioEquipe
    {
        public int UsuarioId { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe{ get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;
        public DateTime DataEntrada { get; set; }
        public required string Funcao { get; set; }
        public required string Ativo { get; set; }
    }
}
