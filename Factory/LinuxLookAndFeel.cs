namespace Padroes;

public class LinuxLookAndFeel : LookAndFeel
{
    public override Button CriarButton()
    {
        return new LinuxButton();
    }
    public override Janela CriarJanela()
    {
        return new LinuxJanela();
    }
}
