namespace ReplyAPI.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public List<UsuarioEquipe> UsuarioEquipe { get; } = [];
        public required string Nome { get; set; }
        public required string Setor { get; set; }
        public required string Responsavel { get; set; }
        public required string Descricao { get; set; }
    }
}
