using ReplyAPI.Models;

namespace ReplyAPI.Repositories.Interface
{
    public interface IProjetoRepository
    {
        Task <IEnumerable<Projetos>> GetAllProjetos();
        Task AddProjeto(Projetos projeto);
        Task DeleteProjeto(int projetoId);
        Task UpdateProjeto (Projetos projeto);
        Task Save();
    }
}
