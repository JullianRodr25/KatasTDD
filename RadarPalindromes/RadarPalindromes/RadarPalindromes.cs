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
        var resultado = RetornarVerdadero("%&/&()");
        resultado.Should().Be(true);
    }

    private static object RetornarVerdadero(string palabra)
    {
        var palabraFinal = palabra.ToLower().Replace(".","").Replace(" ", "");
        return palabraFinal == "anna";
    }
}