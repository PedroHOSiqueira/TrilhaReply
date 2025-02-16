using Microsoft.EntityFrameworkCore;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Repositories
{
    public class UsuarioEquipeRepository(Contexts context) : IUsuarioEquipesRepository
    {
        public Task Save()
        {
            return context.SaveChangesAsync();
        }
        public async Task<IEnumerable<UsuarioEquipe>> GetAllUsuarioEquipes()
        {
            return await context.UsuarioEquipe.ToListAsync();
        }

        public async Task AddUsuarioEquipe(UsuarioEquipe usuarioEquipe)
        {
            context.UsuarioEquipe.Add(usuarioEquipe);
            await Save();
        }

        public async Task DeleteUsuarioEquipe(int usuarioId, int equipeId)
        {
            UsuarioEquipe usuarioEquipe= await context.UsuarioEquipe.FindAsync(usuarioId, equipeId);

            if (usuarioEquipe != null)
            {
                context.UsuarioEquipe.Remove(usuarioEquipe);
                await Save();
            }
            else
            {
                Console.WriteLine("Usuário/Equipe não encontrado");
            }
        }

        public async Task UpdateUsuarioEquipe(UsuarioEquipe usuarioEquipe)
        {
            var currentEquipe = await context.UsuarioEquipe.FindAsync(usuarioEquipe.UsuarioId, usuarioEquipe.EquipeId);

            if (currentEquipe != null)
            {
                context.ChangeTracker.Clear();
                context.UsuarioEquipe.Update(usuarioEquipe);
                await Save();
            }
            else
            {
                Console.WriteLine("Equipe e usuário não encontrados");
            }
        }
    }
}
