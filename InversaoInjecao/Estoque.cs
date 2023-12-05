    namespace Padroes;

    public class Estoque
    {
        // public IProduto Produto;
        public List<IProduto> Produtos;
        // public Estoque(IProduto produto)
        // {
        //     Produto = produto;
        // }
        public Estoque(List<IProduto> produtos)
        {
            Produtos = produtos;
        }
        // public void Vender()
        // {
        //     Produto.Vender();
        // }

        public void Vender()
        {
            foreach (IProduto produto in Produtos)
            {
                produto.Vender();
            }
        }
    }