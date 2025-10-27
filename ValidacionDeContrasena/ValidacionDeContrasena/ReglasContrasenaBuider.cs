namespace ValidacionDeContrasena;

public class contrasenaResult
{
    public bool esValida { get; set; }
}

public class ReglasContrasenaBuider(string contrasena)
{
    private readonly contrasenaResult _result = new();

    public ReglasContrasenaBuider ContieneGuionBajo()
    {
        _result.esValida = contrasena.Contains('_');
        return this;
    }

    public ReglasContrasenaBuider ContieneNumero()
    {
        _result.esValida = contrasena.Any(char.IsDigit);
        return this;
    }

    public ReglasContrasenaBuider ContieneMinuscula()
    {
        _result.esValida = contrasena.Any(char.IsLower);
        return this;
    }

    public ReglasContrasenaBuider ContieneMayuscula()
    {
        _result.esValida = contrasena.Any(char.IsUpper);
        return this;
    }

    public ReglasContrasenaBuider ContieneMinimoCaracter(int numeroCaracteres)
    {
        _result.esValida = contrasena.Length >= numeroCaracteres;
        return this;
    }

    public contrasenaResult Build()
    {
        return _result;
    }
}