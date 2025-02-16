namespace ReplyAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public List<UsuarioEquipe> UsuarioEquipe{ get; } = [];
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public required string Cargo { get; set; }
    }
}
