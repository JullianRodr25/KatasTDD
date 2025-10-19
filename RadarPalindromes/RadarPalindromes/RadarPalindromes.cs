using System.Text.RegularExpressions;
using FluentAssertions;

namespace RadarPalindromes;

public class RadarPalindromes
{
    [Theory]
    [InlineData("Anna", true)]
    [InlineData("ANNA", true)]
    [InlineData("AnNa", true)]
    [InlineData("anna", true)]
    public void Si_EnvioUnaPalabraConMayusculasOMinusculas_Debe_IgnorarlasYRetornarVerdadero(string palabra,
        bool valorEsperado)
    {
        var resultado = EsPalindromo(palabra);
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("An..na. ", true)]
    [InlineData("A N N A", true)]
    public void Si_EnvioUnaPalabraPuntosYEspacios_Debe_IgnorarlasYRetornarVerdadero(string valorIngreso, bool valorEsperado)
    {
        var resultado = EsPalindromo(valorIngreso);
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("%&/&()", "La palabra contiene caracteres no alfanuméricos.")]
    [InlineData("&&&&&&&&&", "La palabra contiene caracteres no alfanuméricos.")]
    [InlineData("%&%(!", "La palabra contiene caracteres no alfanuméricos.")]
    public void Si_EnvioUnaPalabraQueNoSeaAlfanumérica_Debe_RetornarUnError(string valorIngreso, string mensajeError)
    {
        var resultado = () => EsPalindromo(valorIngreso);
        resultado.Should().Throw<ArgumentException>().WithMessage(mensajeError);
    }

    [Theory]
    [InlineData("Prueba", false)]
    [InlineData("Hola", false)]
    [InlineData("123", false)]
    public void Si_EnvioUnaPalabraQueNoSeaPalindroma_Debe_RetornarFalse(string valorIngreso, bool valorEsperado)
    {
        var resultado = EsPalindromo(valorIngreso);
        resultado.Should().Be(valorEsperado);
    }

    private static bool EsPalindromo(string palabra)
    {
        if (string.IsNullOrWhiteSpace(palabra))
            return false;
        
        var palabraFinal = new string(palabra
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());
        
        if (palabraFinal.Length == 0)
            throw new ArgumentException("La palabra contiene caracteres no alfanuméricos.");

        var palabraInvertida = new string(palabraFinal.Reverse().ToArray());

        return palabraFinal == palabraInvertida;
    }
}