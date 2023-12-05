namespace Padroes;

public class App
{
    private Janela Janela;
    private Button Botao;
    private LookAndFeel Lf;

    public App(LookAndFeel lf){
        Lf = lf;
        Botao = lf.CriarButton();
        Janela = lf.CriarJanela();
    }

    public void BotaoClick()
    {
        Botao.Click();
    }
}