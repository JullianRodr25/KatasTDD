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

    [Fact]
    public void Si_Jugador1TieneDosPuntosYJugador2Cero_Debe_Regresarthirty()
    {
        var resultado = CalcularPuntajeTennis(2, 0);
        
        resultado.Should().Be("thirty");
    }

    private static string CalcularPuntajeTennis(int puntosJugador1, int puntosJugador2)
    {
        if (puntosJugador1 == 0 && puntosJugador2 == 0)
            return "Love";
        
        if (puntosJugador1 == 1 && puntosJugador2 == 0)
            return "Fifteen";
        
        return "thirty";
    }
}