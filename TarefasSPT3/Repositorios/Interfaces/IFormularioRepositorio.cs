using TarefasSPT3.Models;

namespace TarefasSPT3.Repositorios.Interfaces
{
    public interface IFormularioRepositorio
    {
        Task<List<Formulario>> BuscarTodosFormularios();
        Task<Formulario> BuscarPorId(int id);
        Task<Formulario> Adicionar(Formulario formulario);
        Task<Formulario> Atualizar(Formulario formulario, int id);
        Task<bool> Apagar(int id);
    }
}