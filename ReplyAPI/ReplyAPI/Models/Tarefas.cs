namespace ReplyAPI.Models
{
    public class Tarefas
    {
        public int Id { get; set; }
        public int ProjetosId { get; set; }
        public Projetos Projetos { get; } = null!;
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required string Status { get; set; }

    }
}
