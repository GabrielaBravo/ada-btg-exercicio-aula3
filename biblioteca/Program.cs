using biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        string logo = ($"-----------------------------------------{Environment.NewLine}---------- Biblioteca ADA|BTG -----------{Environment.NewLine}-----------------------------------------");
        Console.WriteLine(logo);

        Livro livro1 = new Livro(1, 10, "Codigo Limpo", true);
        Pessoa pessoa1 = new Pessoa(1, "Nina", true);
        Emprestimo emprestimo = new Emprestimo();

        Livro livro2 = new Livro(2, 0, "C# in a Nutshell", false);
        Pessoa pessoa2 = new Pessoa(2, "Bete", true);

        Console.Write("Digite o ID do livro: ");
        int livroEscolhido = int.Parse(Console.ReadLine());

        Console.Write("Digite o ID da pessoa: ");
        int pessoaEscolhida = int.Parse(Console.ReadLine());

        Livro livroSelecionado = livroEscolhido == 1 ? livro1 : livro2;
        Pessoa pessoaSelecionada = pessoaEscolhida == 1 ? pessoa1 : pessoa2;

        emprestimo.EmprestarLivro(livroSelecionado, pessoaSelecionada, DateTime.Now, DateTime.Now.AddDays(15));

        pessoaSelecionada.ConsultarStatus();

        livroSelecionado.ConsultarDisponibilidade();
        livroSelecionado.ConsultarQuantidadeEstoque();

        emprestimo.DevolucaoLivro(livroSelecionado);


        Console.ReadLine();
    }
}