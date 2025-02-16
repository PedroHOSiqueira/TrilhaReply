using ReplyAPI.Models;

namespace ReplyAPI.Repositories.Interface
{
    public interface ITarefasRepository
    {
        Task<IEnumerable<Tarefas>> GetAllTarefas();
        Task AddTarefas(Tarefas tarefa);
        Task DeleteTarefas(int tarefaId);
        Task UpdateTarefas(Tarefas tarefa);
        Task Save();
    }
}
