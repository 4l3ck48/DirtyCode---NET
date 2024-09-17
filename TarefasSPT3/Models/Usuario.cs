using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TarefasSPT3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }  
        public int Cpf { get; set; }

        public string Senha { get; set; }

        public int Telefone { get; set; }
    }
}