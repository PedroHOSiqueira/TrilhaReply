using Microsoft.EntityFrameworkCore;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Repositories
{
    public class EquipesRepository(Contexts context) : IEquipesRepository
    {
        public Task Save()
        {
            return context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Equipe>> GetAllEquipes()
        {
            return await context.Equipe.ToListAsync();
        }
        public async Task AddEquipe(Equipe equipe)
        {
             context.Equipe.Add(equipe);
            await Save();
        }
        public async Task DeleteEquipe(int equipeId)
        {

            Equipe equipe = await context.Equipe.FindAsync(equipeId);

            if (equipe != null)
            {
                context.Equipe.Remove(equipe);
                await Save();
            }
            else
            {
                Console.WriteLine("Equipe não encontrada");
            }
        }
        public async Task UpdateEquipe(Equipe equipe)
        {
            var currentEquipe = await context.Equipe.FindAsync(equipe.Id);
            if (currentEquipe != null)
            {
                context.ChangeTracker.Clear();
                context.Equipe.Update(equipe);
                await Save();
            }
            else
            {
                Console.WriteLine("Equipe não encontrada");
            }
        }
    }
}
