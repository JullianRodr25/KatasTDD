using FluentAssertions;

namespace RadarPalindromes;

public class RadarPalindromes
{
    [Fact]
    public void Si_EnviamosUnaPalabra_Debe_RetornarVerdadero()
    {
       var resultado = RetornarVerdadero("Palabra");
       resultado.Should().Be(true);
    }

    private object RetornarVerdadero(string palabra)
    {
        return true;
    }
}