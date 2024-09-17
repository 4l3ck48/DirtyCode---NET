using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
        {
            var usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
        {
            var usuario = await _usuarioRepositorio.BuscarPorId(id);

            if (usuario == null)
            {
                return NotFound($"Usuário com ID {id} não encontrado.");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CreateUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var novoUsuario = await _usuarioRepositorio.Adicionar(usuario);
            return CreatedAtAction(nameof(GetUsuarioById), new { id = novoUsuario.Id }, novoUsuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            if (id <= 0 || usuario == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var usuarioAtualizado = await _usuarioRepositorio.Atualizar(usuario, id);

            if (usuarioAtualizado == null)
            {
                return NotFound($"Usuário com ID {id} não encontrado.");
            }

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUsuario(int id)
        {
            var usuarioExcluido = await _usuarioRepositorio.Apagar(id);

            if (!usuarioExcluido)
            {
                return NotFound($"Usuário com ID {id} não encontrado.");
            }

            return NoContent();
        }
    }
}