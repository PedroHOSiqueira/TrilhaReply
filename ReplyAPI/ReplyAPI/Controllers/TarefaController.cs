using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Controllers
{
    public class TarefaController(ITarefasRepository repository) : Controller
    {
        private readonly ITarefasRepository _repository = repository;

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAllTarefas()
        {
            var tarefas = await _repository.GetAllTarefas();
            return Ok(tarefas);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> AddTarefa([FromBody] Tarefas tarefas)
        {
            await _repository.AddTarefas(tarefas);

            var updatedTarefas = await _repository.GetAllTarefas();
            return Ok(updatedTarefas);
        }

        [HttpPut]
        [Route("api/[controller]/Update")]
        public async Task<IActionResult> UpdateTarefa([FromBody] Tarefas tarefas)
        {
            await _repository.UpdateTarefas(tarefas);

            var updatedTarefas = await _repository.GetAllTarefas();
            return Ok(updatedTarefas);
        }

        [HttpDelete]
        [Route("api/[controller]/Delete/{id}")]
        public async Task<IActionResult> DeleteTarefa(int id)
        {
            await _repository.DeleteTarefas(id);
            return NoContent();
        }
    }
}
