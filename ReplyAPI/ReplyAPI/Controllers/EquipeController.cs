using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ReplyAPI.Data;
using ReplyAPI.Models;
using ReplyAPI.Repositories.Interface;

namespace ReplyAPI.Controllers
{
    public class EquipeController(IEquipesRepository repository) : Controller
    {
        private readonly IEquipesRepository _repository = repository;

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAllEquipes()
        {
            var equipes = await _repository.GetAllEquipes();
            return Ok(equipes);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> AddEquipe([FromBody] Equipe equipes)
        {
            await _repository.AddEquipe(equipes);

            var updatedEquipes = await _repository.GetAllEquipes();
            return Ok(updatedEquipes);
        }

        [HttpPut()]
        [Route("api/[controller]/Update")]
        public async Task<IActionResult> UpdateEquipe([FromBody] Equipe equipes)
        {
            await _repository.UpdateEquipe(equipes);

            var updatedEquipes = await _repository.GetAllEquipes();
            return Ok(updatedEquipes);
        }

        [HttpDelete()]
        [Route("api/[controller]/Delete/{id}")]
        public async Task<IActionResult> DeleteEquipe(int id)
        {
            await _repository.DeleteEquipe(id);
            return NoContent();
        }
    }
}
