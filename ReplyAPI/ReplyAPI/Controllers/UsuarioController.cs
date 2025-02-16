using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Controllers
{
    public class UsuarioController(IUsuarioRepository repository) : Controller
    {
        private readonly IUsuarioRepository _repository = repository;

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAllUsuarios()
        {
            var usuarios = await _repository.GetAllUsuarios();
            return Ok(usuarios);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario usuarios)
        {
            await _repository.AddUsuario(usuarios);

            var updatedUsuarios = await _repository.GetAllUsuarios();
            return Ok(updatedUsuarios);
        }

        [HttpPut()]
        [Route("api/[controller]/Update")]
        public async Task<IActionResult> UpdateUsuario([FromBody] Usuario usuarios)
        {
            await _repository.UpdateUsuario(usuarios);

            var updatedUsuarios = await _repository.GetAllUsuarios();
            return Ok(updatedUsuarios);
        }

        [HttpDelete()]
        [Route("api/[controller]/Delete/{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            await _repository.DeleteUsuario(id);
            return NoContent();
        }
    }
}
