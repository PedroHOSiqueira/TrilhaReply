using Microsoft.EntityFrameworkCore;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Repositories
{
    public class UsuarioRepository(Contexts context) : IUsuarioRepository
    {
        //private readonly Contexts context = context;

        public Task Save()
        {
            return context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            return await context.Usuario.ToListAsync();
        }

        public async Task AddUsuario(Usuario usuario)
        {
            context.Usuario.Add(usuario);
            await Save();
        }

        public async Task DeleteUsuario(int usuarioId)
        {
            Usuario usuario = await context.Usuario.FindAsync(usuarioId);

            if (usuario != null)
            {
                context.Usuario.Remove(usuario);
                await Save();
            }
            else
            {
                Console.WriteLine("Usuário não encontrado");
            }
        }

        public async Task UpdateUsuario(Usuario usuario)
        {
            var currentUsuario = await context.Usuario.FindAsync(usuario.Id);

            if (currentUsuario != null)
            {
                context.ChangeTracker.Clear();
                context.Usuario.Update(usuario);
                await Save();
            }
            else
            {
                Console.WriteLine("Usuário não encontrados");
            }
        }
    }
}

