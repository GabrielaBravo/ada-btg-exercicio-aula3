namespace ExercicioClasse.Console
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEstoque()
        {
            return preco * quantidade;
            
        }

        public void AdicionarProduto( int quantidadeAdicionada)
        {
            
            quantidade += quantidadeAdicionada;
            
        }

        public void RemoverProduto(int quantidadeRemovida)
        {
            quantidade -= quantidadeRemovida;
        }

        public override string ToString()
        {
            return $"Nome: {nome} | Preço: R${preco:F2} | Quantidade: {quantidade} | Valor total no estoque: R${ValorTotalEstoque():F2}";
        }
    }
}
