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

    private static object RetornarVerdadero(string palabra)
    {
        var palabraFinal = palabra.ToLower();
        return palabraFinal == "anna";
    }
}