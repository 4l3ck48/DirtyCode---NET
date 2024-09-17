using Microsoft.AspNetCore.Mvc;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> GetAllProdutos()
        {
            var produtos = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutoById(int id)
        {
            var produto = await _produtoRepositorio.BuscarPorId(id);

            if (produto == null)
            {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProduto([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var novoProduto = await _produtoRepositorio.Adicionar(produto);
            return CreatedAtAction(nameof(GetProdutoById), new { id = novoProduto.Id_produto }, novoProduto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> UpdateProduto(int id, [FromBody] Produto produto)
        {
            if (id <= 0 || produto == null)
            {
                return BadRequest("Dados inválidos.");
            }

            var produtoAtualizado = await _produtoRepositorio.Atualizar(produto, id);

            if (produtoAtualizado == null)
            {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            return Ok(produtoAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(int id)
        {
            var produtoExcluido = await _produtoRepositorio.Apagar(id);

            if (!produtoExcluido)
            {
                return NotFound($"Produto com ID {id} não encontrado.");
            }

            return NoContent();
        }
    }
}