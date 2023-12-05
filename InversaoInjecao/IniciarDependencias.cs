using Microsoft.Extensions.DependencyInjection;

namespace Padroes;

public static class IniciarDependencias
{
    public static IServiceProvider ServiceProvider {get; set;}
    public static IServiceProvider Iniciar()
    {
        Console.WriteLine("Iniciando Dependências");
        IServiceProvider service = new ServiceCollection()
            .ConfigurarProdutos()
            .ConfigurarEstoque()
            .ConfigurarProdutosTransient()
            .BuildServiceProvider();
        
        ServiceProvider = service;

        return ServiceProvider;
    }
}