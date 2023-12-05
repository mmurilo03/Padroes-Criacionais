namespace Padroes;

public class Produto : IProduto
{
    public string Nome {get; set;}
    public double Preco {get; set;}

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void Vender() {
        Console.WriteLine($"{Nome} Vendido! Preço: {Preco}!");
    }
}