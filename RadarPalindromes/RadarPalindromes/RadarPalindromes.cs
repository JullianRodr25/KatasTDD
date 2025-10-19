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
    
    public void Si_EnvioUnaPalabraConMayusculasOMinusculas_Debe_IgnorarlasYRetornarVerdadero(string palabra, bool valorEsperado)
    {
        var resultado = EsPalindromo(palabra);
        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_EnvioUnaPalabraPuntosYEspacios_Debe_IgnorarlasYRetornarVerdadero()
    {
        var resultado = EsPalindromo("An..na. ");
        resultado.Should().Be(true);
    }
    [Fact]
    public void Si_EnvioUnaPalabraQueNoSeaAlfanumérica_Debe_RetornarUnError()
    {
        var resultado = () => EsPalindromo("%&/&()");
        resultado.Should().Throw<ArgumentException>().WithMessage("La palabra contiene caracteres no alfanuméricos.");
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
    
    private static object EsPalindromo(string palabra)
    {
        var palabraFinal = palabra.ToLower().Replace(".","").Replace(" ", "");
        
        if (!Regex.IsMatch(palabraFinal, @"^[a-z0-9]+$"))
            throw new ArgumentException("La palabra contiene caracteres no alfanuméricos.");
        
        var palabraInvertida = new string(palabraFinal.Reverse().ToArray());
        
        return palabraFinal == palabraInvertida;
    }
}