using Microsoft.EntityFrameworkCore;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Repositories
{
    public class TarefasRepository(Contexts context) : ITarefasRepository
    {

        public Task Save()
        {
            return context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Tarefas>> GetAllTarefas()
        {
            return await context.Tarefas.ToListAsync();
        }

        public async Task AddTarefas(Tarefas tarefa)
        {
            context.Tarefas.Add(tarefa);
            await Save();
        }

        public async Task DeleteTarefas(int tarefaId)
        {
            Tarefas tarefa = await context.Tarefas.FindAsync(tarefaId);

            if (tarefa != null)
            {
                context.Tarefas.Remove(tarefa);
                await Save();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada");
            }
        }

        public async Task UpdateTarefas(Tarefas tarefa)
        {
            var currentTarefa = await context.Tarefas.FindAsync(tarefa.Id);
            if (currentTarefa != null)
            {
                context.ChangeTracker.Clear();
                context.Tarefas.Update(tarefa);
                await Save();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada");
            }
        }
    }
}
