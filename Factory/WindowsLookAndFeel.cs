namespace Padroes;

public class WindowsLookAndFeel : LookAndFeel
{
    public override Button CriarButton()
    {
        return new WindowsButton();
    }
    public override Janela CriarJanela()
    {
        return new WindowsJanela();
    }
}
