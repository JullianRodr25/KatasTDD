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
    public void Si_Jugador1TieneDosPuntosYJugador2Cero_Debe_RegresarThirty()
    {
        var resultado = CalcularPuntajeTennis(2, 0);

        resultado.Should().Be("Thirty");
    }

    [Fact]
    public void Si_Jugador1TieneTresPuntosYJugador2Cero_Debe_RegresarForty()
    {
        var resultado = CalcularPuntajeTennis(3, 0);

        resultado.Should().Be("Forty");
    }
    
    
    [Fact]
    public void Si_Jugador1TieneTresPuntosYJugador2Tres_Debe_RegresarFortyAll()
    {
        var resultado = CalcularPuntajeTennis(3, 3);

        resultado.Should().Be("Forty-All");
    }
    
    private static string CalcularPuntajeTennis(int puntosJugador1, int puntosJugador2)
    {
        
        if (puntosJugador1 == 0 && puntosJugador2 == 0)
            return "Love";
        
        if (puntosJugador1 == 1 && puntosJugador2 == 0)
            return "Fifteen";

        if (puntosJugador1 == 2 && puntosJugador2 == 0)
            return "Thirty";
        
        if (puntosJugador1 == 3 && puntosJugador2 == 0)
            return "Forty";

        return string.Empty;
    }
}