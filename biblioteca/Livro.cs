using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Livro
    {
        public int idLivro { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Titulo { get; set; }
        public bool Disponibilidade { get; set; }

        public Livro(int idLivro, int quantidadeEstoque, string titulo, bool disponibilidade)
        {
            this.idLivro = idLivro;
            QuantidadeEstoque = quantidadeEstoque;
            Titulo = titulo;
            Disponibilidade = disponibilidade;
        }

        public void ConsultarQuantidadeEstoque()
        {
            Console.WriteLine($"Quantidade em estoque de livro '{Titulo}': {QuantidadeEstoque}");
        }

        public void ConsultarDisponibilidade()
        {
            Console.WriteLine($"Status do livro '{Titulo}': {(Disponibilidade == true ? "Disponível" : "Indisponível")}");
        }
    }
}
