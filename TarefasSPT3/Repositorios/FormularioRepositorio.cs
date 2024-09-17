using Microsoft.EntityFrameworkCore;
using TarefasSPT3.Data;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Repositorios
{
    public class FormularioRepositorio : IFormularioRepositorio
    {
        private readonly FIAPDBContext _context;

        public FormularioRepositorio(FIAPDBContext context)
        {
            _context = context;
        }

        public async Task<List<Formulario>> BuscarTodosFormularios()
        {
            return await _context.Formularios.ToListAsync();
        }

        public async Task<Formulario> BuscarPorId(int id)
        {
            return await _context.Formularios.FirstOrDefaultAsync(f => f.Id_formulario == id);
        }

        public async Task<Formulario> Adicionar(Formulario formulario)
        {
            _context.Formularios.Add(formulario);
            await _context.SaveChangesAsync();
            return formulario;
        }

        public async Task<Formulario> Atualizar(Formulario formulario, int id)
        {
            var formularioExistente = await BuscarPorId(id);

            if (formularioExistente == null)
            {
                return null;
            }

            formularioExistente.StatusAlergia = formulario.StatusAlergia;
            formularioExistente.DescricaoAlergia = formulario.DescricaoAlergia;
            formularioExistente.DescricaoPele = formulario.DescricaoPele;

            _context.Formularios.Update(formularioExistente);
            await _context.SaveChangesAsync();

            return formularioExistente;
        }

        public async Task<bool> Apagar(int id)
        {
            var formulario = await BuscarPorId(id);
            if (formulario == null)
            {
                return false;
            }

            _context.Formularios.Remove(formulario);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}