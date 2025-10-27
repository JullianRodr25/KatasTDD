namespace ValidacionDeContrasena;

public class Validador
{
    public static bool ValidaContrasena(string contrasena, int tipoValidacion)
    {
        return tipoValidacion switch
        {
            1 => validarTipo1(contrasena),
            2 => validarTipo2(contrasena),
            3 => validarTipo3(contrasena),
        };
    }

    private static bool validarTipo3(string contrasena)
    {
        var regla = new ReglasContrasenaBuider(contrasena).ContieneMinimoCaracter(16).ContieneMayuscula()
            .ContieneMinuscula().ContieneGuionBajo().Build();
        return regla.esValida;
    }

    private static bool validarTipo2(string contrasena)
    {
        var regla = new ReglasContrasenaBuider(contrasena).ContieneMinimoCaracter(6).ContieneMayuscula()
            .ContieneMinuscula().ContieneNumero().Build();
        return regla.esValida;
    }

    private static bool validarTipo1(string contrasena)
    {
        var regla = new ReglasContrasenaBuider(contrasena).ContieneMinimoCaracter(8).ContieneMayuscula()
            .ContieneMinuscula()
            .ContieneNumero().ContieneGuionBajo().Build();
        return regla.esValida;
    }
}