using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Controllers
{
    public class EquipeUsuarioController(IUsuarioEquipesRepository repository) : Controller
    {
        private readonly IUsuarioEquipesRepository _repository = repository;

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAllUsuarioEquipes()
        {
            var usuariosEquipes = await _repository.GetAllUsuarioEquipes();
            return Ok(usuariosEquipes);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> AddUsuarioEquipe([FromBody] UsuarioEquipe usuariosEquipes)
        {
            await _repository.AddUsuarioEquipe(usuariosEquipes);

            var updatedUsuariosEquipes = await _repository.GetAllUsuarioEquipes();
            return Ok(updatedUsuariosEquipes);
        }

        [HttpPut()]
        [Route("api/[controller]/Update")]
        public async Task<IActionResult> UpdateProjeto([FromBody] UsuarioEquipe usuariosEquipes)
        {
            await _repository.UpdateUsuarioEquipe(usuariosEquipes);

            var updatedUsuariosEquipes = await _repository.GetAllUsuarioEquipes();
            return Ok(updatedUsuariosEquipes);
        }

        [HttpDelete()]
        [Route("api/[controller]/Delete/{usuarioId}/{equipeId}")]
        public async Task<IActionResult> DeleteProjeto(int usuarioId, int equipeId )
        {
            await _repository.DeleteUsuarioEquipe(usuarioId, equipeId);
            return NoContent();
        }
    }
}
