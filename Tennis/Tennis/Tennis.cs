using FluentAssertions;

namespace Tennis;

public class Tennis
{
    [Fact]
    public void Si_AmbosJugadoresTienenCeroPuntos_RegresaLove()
    {
        var resultado = CalcularPuntajeTennis(0, 0);

        resultado.Should().Be("Love");
    }
    
    [Fact]
    public void Si_Jugador1TieneUnPuntoYJugador2Cero_RegresaFifteen()
    {
        var resultado = CalcularPuntajeTennis(1, 0);
        
        resultado.Should().Be("Fifteen");
    }

    private static string CalcularPuntajeTennis(int puntosJugador1, int puntosJugador2)
    {
        return "Love";
    }
}