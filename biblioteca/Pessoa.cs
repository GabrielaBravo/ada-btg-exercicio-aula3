using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public bool StatusCadastro { get; set; }


        public Pessoa(int idPessoa, string nome, bool statusCadastro)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            StatusCadastro = statusCadastro;
        }
        public void ConsultarStatus()
        {
            Console.WriteLine($"Status de Cadastro de {Nome}: {(StatusCadastro == true ? "Ativo" : "Inativo")}");
        }
    }
}
