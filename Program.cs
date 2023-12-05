using Microsoft.Extensions.DependencyInjection;
using Padroes;

Console.WriteLine("===============Singleton===============");

Banco banco = Banco.GetInstance();
Console.WriteLine("Saldo atual: " + banco.GetSaldo());
banco.Sacar(908.00);
Console.WriteLine("Saldo atual: " + banco.GetSaldo());
banco.Depositar(192.00);
Console.WriteLine("Saldo atual: " + banco.GetSaldo());

Console.WriteLine("===============Builder===============");

UsuarioBuilder usuarioBuilder = new();

usuarioBuilder.ComNome("Fuleco").ComEmail("fuleco@gmail.com").ComIdade(19);

Usuario usuario = usuarioBuilder.ToUsuario();

Console.WriteLine("Nome: " + usuario.Nome + "\nEmail: " + usuario.Email + "\nIdade: " + usuario.Idade);

Console.WriteLine("===============Factory===============");

App app1 = new(new WindowsLookAndFeel());
App app2 = new(new LinuxLookAndFeel());

app1.BotaoClick();
app2.BotaoClick();

Console.WriteLine("===============Prototype===============");

Quadro q = new("Quadro 1");

Parede p = new(10L, "Parede 1", q);

Parede p2 = (Parede) p.Clone();

Console.WriteLine(p.Altura);
Console.WriteLine(p.Nome);
Console.WriteLine(p.Quadro.Nome);
Console.WriteLine(p2.Altura);
Console.WriteLine(p2.Nome);
Console.WriteLine(p2.Quadro.Nome);

p.Altura = 20L;
p.Nome = "Parede mudou";
p.Quadro.Nome = "Quadro mudou";

Console.WriteLine("===============Após clonar===============");

Console.WriteLine(p.Altura);
Console.WriteLine(p.Nome);
Console.WriteLine(p.Quadro.Nome);
Console.WriteLine(p2.Altura);
Console.WriteLine(p2.Nome);
Console.WriteLine(p2.Quadro.Nome);

Console.WriteLine("===============Inversão / Injeção===============");

IServiceProvider serviceProvider = IniciarDependencias.Iniciar();

Estoque estoque = serviceProvider.GetRequiredService<Estoque>();
estoque.Vender();
Console.WriteLine("Produto preço aleatorio");
IProduto produto = serviceProvider.GetRequiredService<IProduto>();
produto.Vender();
IProduto produto2 = serviceProvider.GetRequiredService<IProduto>();
produto2.Vender();
