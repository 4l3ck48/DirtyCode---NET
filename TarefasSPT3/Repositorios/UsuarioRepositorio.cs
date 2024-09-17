using Microsoft.EntityFrameworkCore;
using TarefasSPT3.Data;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace TarefasSPT3.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly FIAPDBContext _context;

        public UsuarioRepositorio(FIAPDBContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            var usuarioExistente = await BuscarPorId(id);

            if (usuarioExistente == null)
            {
                return null;
            }

            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Email;
            usuarioExistente.Cpf = usuario.Cpf;
            usuarioExistente.Senha = usuario.Senha;
            usuarioExistente.Telefone = usuario.Telefone;

            _context.Usuarios.Update(usuarioExistente);
            await _context.SaveChangesAsync();

            return usuarioExistente;
        }

        public async Task<bool> Apagar(int id)
        {
            var usuario = await BuscarPorId(id);
            if (usuario == null)
            {
                return false;
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}