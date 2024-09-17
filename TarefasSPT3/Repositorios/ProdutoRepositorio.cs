using Microsoft.EntityFrameworkCore;
using TarefasSPT3.Data;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly FIAPDBContext _context;

        public ProdutoRepositorio(FIAPDBContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> BuscarTodosProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(p => p.Id_produto == id);
        }

        public async Task<Produto> Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> Atualizar(Produto produto, int id)
        {
            var produtoExistente = await BuscarPorId(id);

            if (produtoExistente == null)
            {
                return null;
            }

            produtoExistente.Nome = produto.Nome;
            produtoExistente.Preco = produto.Preco;

            _context.Produtos.Update(produtoExistente);
            await _context.SaveChangesAsync();

            return produtoExistente;
        }

        public async Task<bool> Apagar(int id)
        {
            var produto = await BuscarPorId(id);
            if (produto == null)
            {
                return false;
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}