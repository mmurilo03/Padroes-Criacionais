namespace Padroes;

public sealed class Banco
{
  private static Banco? BancoSingleton;
  private double Saldo { get; set; }

  private Banco()
  {
    Saldo = 50000.00;
  }

  public static Banco GetInstance()
  {
    BancoSingleton ??= new();
    return BancoSingleton;
  }

  public void Sacar(double valor)
  {
    Saldo -= valor;
  }

  public void Depositar(double valor)
  {
    Saldo += valor;
  }

  public double GetSaldo()
  {
    return Saldo;
  }
}