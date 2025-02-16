using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Controllers
{
    public class ProjetoController(IProjetoRepository repository) : ControllerBase
    {

        private readonly IProjetoRepository _repository = repository;

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAllProjetos()
        {
            var projetos = await _repository.GetAllProjetos();
            return Ok(projetos);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> AddProjeto(Projetos projetos)
        {
            await _repository.AddProjeto(projetos);

            var updatedProjects = await _repository.GetAllProjetos();
            return Ok(updatedProjects);
        }

        [HttpPut()]
        [Route("api/[controller]/Update")]
        public async Task<IActionResult> UpdateProjeto(Projetos projetos)
        {
           await _repository.UpdateProjeto(projetos);

           var updatedProjects = await _repository.GetAllProjetos();
           return Ok(updatedProjects);
        }

        [HttpDelete]
        [Route("api/[controller]/Delete/{id}")]
        public async Task<IActionResult> DeleteProjeto(int id)
        {
            await _repository.DeleteProjeto(id);
            return NoContent();
        }
    }
}
