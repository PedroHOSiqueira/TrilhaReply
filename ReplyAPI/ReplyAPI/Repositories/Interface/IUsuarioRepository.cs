using ReplyAPI.Models;

namespace ReplyAPI.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllUsuarios();
        Task AddUsuario(Usuario usuario);
        Task DeleteUsuario(int usuarioId);
        Task UpdateUsuario(Usuario usuario);
        Task Save();
    }
}