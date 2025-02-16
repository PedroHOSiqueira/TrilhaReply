using ReplyAPI.Models;

namespace ReplyAPI.Repositories.Interface
{
    public interface IEquipesRepository
    {
        Task<IEnumerable<Equipe>> GetAllEquipes();
        Task AddEquipe(Equipe equipe);
        Task DeleteEquipe(int equipesId);
        Task UpdateEquipe(Equipe equipe);
        Task Save();
    }
}
