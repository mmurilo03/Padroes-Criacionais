namespace Padroes;

public class UsuarioBuilder
{
    private readonly Usuario Usuario;

    public UsuarioBuilder()
    {
        Usuario = new();
    }

    public UsuarioBuilder ComNome(string nome)
    {
        Usuario.Nome = nome;
        return this;
    }

    public UsuarioBuilder ComEmail(string email)
    {
        Usuario.Email = email;
        return this;
    }

    public UsuarioBuilder ComIdade(int idade)
    {
        Usuario.Idade = idade;
        return this;
    }

    public Usuario ToUsuario()
    {
        ValidarUsuario();
        return Usuario;
    }

    public void  ValidarUsuario()
    {
        if (Usuario.Nome == null || Usuario.Email == null || Usuario.Idade < 0) throw new Exception("Criação de usuário inválida");
    }
}