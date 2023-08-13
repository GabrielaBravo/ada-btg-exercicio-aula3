using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Emprestimo
    {
        public int idEmprestimo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int idPessoa { get; set; }
        public int idLivro { get; set; }
        public List<Livro> livros { get; set; } = new();

        public Emprestimo()
        {
            livros = new();
        }

        public void EmprestarLivro(Livro livro, Pessoa pessoa, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            if (livro.Disponibilidade == true)
            {
                idPessoa = pessoa.IdPessoa;
                idLivro = livro.idLivro;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataDevolucao;
                Console.WriteLine($"{Environment.NewLine}Livro  disponível para empréstimo");
                Console.WriteLine($"{Environment.NewLine}Data do emprestimo:{DataEmprestimo.ToString(" dd/MM/yyyy")} {Environment.NewLine}Data da devolução:{DataDevolucao.ToString(" dd/MM/yyyy")}");

            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Livro não disponível para empréstimo.{Environment.NewLine}");
            }
        }

        public void DevolucaoLivro(Livro livro)
        { 
            idPessoa = 0;
            idLivro = 0;
            DataEmprestimo = DateTime.MinValue;
            DataDevolucao = DateTime.MinValue;
            livro.Disponibilidade = true;
        }
    }
}
