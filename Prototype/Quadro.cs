namespace Padroes;

public class Quadro : ICloneable
{
    public string Nome {get; set;}

    public Quadro (string nome)
    {
        Nome = nome;
    }
    public object Clone()
    {
        return MemberwiseClone();
    }
}