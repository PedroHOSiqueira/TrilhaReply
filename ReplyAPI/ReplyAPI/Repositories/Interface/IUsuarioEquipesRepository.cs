using ReplyAPI.Models;

namespace ReplyAPI.Repositories.Interface
{
    public interface IUsuarioEquipesRepository
    {
        Task<IEnumerable<UsuarioEquipe>> GetAllUsuarioEquipes();
        Task AddUsuarioEquipe(UsuarioEquipe usuarioEquipe);
        Task DeleteUsuarioEquipe(int usuarioId, int equipeId);
        Task UpdateUsuarioEquipe(UsuarioEquipe usuarioEquipe);
        Task Save();
    }
}
