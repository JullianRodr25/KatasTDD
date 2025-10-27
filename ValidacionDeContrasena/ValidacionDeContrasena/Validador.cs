namespace ValidacionDeContrasena;

public class Validador
{
    public static bool ValidaContrasena(string contrasena, int tipoValidacion)
    {
        return tipoValidacion switch
        {
            1 => validarTipo1(contrasena),
            2 => validarTipo2(contrasena),
        };
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