using TarefasSPT3.Models;

namespace TarefasSPT3.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<Produto>> BuscarTodosProdutos();
        Task<Produto> BuscarPorId(int id);
        Task<Produto> Adicionar(Produto produto);
        Task<Produto> Atualizar(Produto produto, int id);
        Task<bool> Apagar(int id);
    }
}