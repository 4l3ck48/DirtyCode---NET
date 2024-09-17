using Microsoft.AspNetCore.Mvc;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        private readonly IFormularioRepositorio _formularioRepositorio;

        public FormularioController(IFormularioRepositorio formularioRepositorio)
        {
            _formularioRepositorio = formularioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Formulario>>> GetAllFormularios()
        {
            var formularios = await _formularioRepositorio.BuscarTodosFormularios();
            return Ok(formularios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Formulario>> GetFormularioById(int id)
        {
            var formulario = await _formularioRepositorio.BuscarPorId(id);

            if (formulario == null)
            {
                return NotFound($"Formulário com ID {id} não encontrado.");
            }

            return Ok(formulario);
        }

        [HttpPost]
        public async Task<ActionResult<Formulario>> CreateFormulario([FromBody] Formulario formulario)
        {
            if (formulario == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var novoFormulario = await _formularioRepositorio.Adicionar(formulario);
            return CreatedAtAction(nameof(GetFormularioById), new { id = novoFormulario.Id_formulario }, novoFormulario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Formulario>> UpdateFormulario(int id, [FromBody] Formulario formulario)
        {
            if (id <= 0 || formulario == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var formularioAtualizado = await _formularioRepositorio.Atualizar(formulario, id);

            if (formularioAtualizado == null)
            {
                return NotFound($"Formulário com ID {id} não encontrado.");
            }

            return Ok(formularioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFormulario(int id)
        {
            var formularioExcluido = await _formularioRepositorio.Apagar(id);

            if (!formularioExcluido)
            {
                return NotFound($"Formulário com ID {id} não encontrado.");
            }

            return NoContent();
        }
    }
}