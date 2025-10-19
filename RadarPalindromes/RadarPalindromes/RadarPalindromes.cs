using FluentAssertions;

namespace RadarPalindromes;

public class RadarPalindromes
{
    [Fact]
    public void Si_EnviamosUnaPalabra_Debe_RetornarVerdadero()
    {
       var resultado = RetornarVerdadero("anna");
       resultado.Should().Be(true);
    }

    private static object RetornarVerdadero(string palabra)
    {
        return palabra == "anna";
    }
}