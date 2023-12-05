using Microsoft.Extensions.DependencyInjection;

namespace Padroes;

public static class Configuracao
{

    public static IServiceCollection ConfigurarProdutos(this IServiceCollection services)
    {
        Console.WriteLine("Configurando");
        // services.AddSingleton<IProduto, Produto>();
        // services.AddSingleton<IProduto, Produto>(provider => {
        //     return new Produto("Nome", 2);
        // });

        services.AddSingleton(provider => {
            List<IProduto> produtos = new()
            {
                new Produto("Assolan", 5),
                new Produto("Icegurt", 6),
                new Produto("Farofa yoki", 7)
            };
            
            return produtos;
        });

        return services;
    }

    public static IServiceCollection ConfigurarEstoque(this IServiceCollection services)
    {
        services.AddSingleton<Estoque>();

        return services;
    }

    public static IServiceCollection ConfigurarProdutosTransient(this IServiceCollection services)
    {
        services.AddTransient<IProduto, Produto>(provider => {
            return new Produto("Produto preço aleatorio", new Random().Next(100));
        });

        return services;
    }
}