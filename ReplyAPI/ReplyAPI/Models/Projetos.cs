using Microsoft.Extensions.Hosting;
namespace ReplyAPI.Models
{
    public class Projetos
    {
        public int Id { get; set; }
        public ICollection<Tarefas> Tarefas{ get; } = [];
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
