using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Repositories
{
    public class ProjetoRepository(Contexts context) : IProjetoRepository
    {
        public Task Save()
        {
           return context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Projetos>> GetAllProjetos()
        {
            return await context.Projetos.ToListAsync();
        }

        public async Task AddProjeto(Projetos projeto)
        {
            context.Projetos.Add(projeto);
            await Save();
        }

        public async Task DeleteProjeto(int projetoId)
        {
            Projetos projeto = await context.Projetos.FindAsync(projetoId);

            if (projeto != null)
            {
                context.Projetos.Remove(projeto);
                await Save();
            } else
            {
                Console.WriteLine("Projeto não encontrado");
            }
        }

        public async Task UpdateProjeto(Projetos projeto)
        {
            var currentProject = await context.Projetos.FindAsync(projeto.Id);
            if (currentProject != null)
            {
               context.ChangeTracker.Clear();
               context.Projetos.Update(projeto);
               await Save();
            }
            else
            {
                Console.WriteLine("Projeto não encontrado");
            }


        }
    }
}
