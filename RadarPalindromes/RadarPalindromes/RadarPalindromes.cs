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
        var resultado = RetornarVerdadero(palabra);
        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_EnvioUnaPalabraPuntosYEspacios_Debe_IgnorarlasYRetornarVerdadero()
    {
        var resultado = RetornarVerdadero("An..na. ");
        resultado.Should().Be(true);
    }
    [Fact]
    public void Si_EnvioUnaPalabraQueNoSeaAlfanumérica_Debe_RetornarUnError()
    {
        var resultado = () => RetornarVerdadero("%&/&()");
        resultado.Should().Throw<ArgumentException>().WithMessage("La palabra contiene caracteres no alfanuméricos.");
    }
    
    [Fact]
    public void Si_EnvioUnaPalabraQueNoSeaPalindroma_Debe_RetornarFalse()
    {
        var resultado = RetornarVerdadero("Prueba");
        resultado.Should().Be(false);
    }
    
    private static object RetornarVerdadero(string palabra)
    {
        var palabraFinal = palabra.ToLower().Replace(".","").Replace(" ", "");
        if (!Regex.IsMatch(palabraFinal, @"^[a-z0-9]+$"))
            throw new ArgumentException("La palabra contiene caracteres no alfanuméricos.");
        var palabraInvertida = new string(palabraFinal.Reverse().ToArray());
        
        return palabraFinal == palabraInvertida;
    }
}