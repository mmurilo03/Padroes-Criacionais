namespace Padroes;

public class Parede : ICloneable
{
  public long Altura {get; set;}
  public string Nome {get; set;}
  public Quadro Quadro {get; set;}

  public long GetAltura(){
    return Altura;
  }

  public void SetAltura(long altura){
    Altura = altura;
  }

  public Parede(long altura, string nome, Quadro quadro)
  {
    Altura = altura;
    Nome = nome;
    Quadro = quadro;
  }

  public object Clone()
  {
    Parede p = (Parede) MemberwiseClone();
    p.Quadro = (Quadro) p.Quadro.Clone();
    return p;
  }
}