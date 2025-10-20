using FluentAssertions;

namespace Tennis;

public class Tennis
{
    [Theory]
    [InlineData(0, 0, "Love-All")]
    [InlineData(1, 1, "Fifteen-All")]
    [InlineData(2, 2, "Thirty-All")]
    public void
        Si_Jugador1YJugador2TieneLosMismosResultadosMenoresDe4DeberiaRetornarLoveAlloFifteenAlloThirtyAlloFortyAll(
            int puntosJugador1, int puntosJugador2, string resultadoEsperado)
    {
        var resultado = CalcularPuntajeTennis(puntosJugador1, puntosJugador2);

        resultado.Should().Be(resultadoEsperado);
    }

    [Fact]
    public void Si_Jugador1TieneTresPuntosYJugador2Tres_Debe_RetornarDeuce()
    {
        var resultado = CalcularPuntajeTennis(3, 3);

        resultado.Should().Be("Deuce");
    }

    [Fact]
    public void Si_AmbosJugadoresTienenAlMenosTresPuntosYUnoTieneUnoMas_DeberiaRetornarAdvantageJugador1oAdvantageJugador2()
    {
        var resultado = CalcularPuntajeTennis(4, 3);

        resultado.Should().Be("Advantage jugador 1");
    }

    private static string CalcularPuntajeTennis(int puntosJugador1, int puntosJugador2)
    {
        string[] nombres = { "Love", "Fifteen", "Thirty", "Forty" };
        if (puntosJugador1 == puntosJugador2)
        {
            return puntosJugador1 >= 3 ? "Deuce" : $"{nombres[puntosJugador1]}-All";
        }

        if (puntosJugador1 >= 3 && puntosJugador2 >= 3)
        {
            if (Math.Abs(puntosJugador1 - puntosJugador2) == 1)
            {
                return puntosJugador1 > puntosJugador2 ? "Advantage jugador 1" : "Advantage jugador 2";
            }
        }

        if (puntosJugador1 < 4 && puntosJugador2 < 4)
        {
            return $"{nombres[puntosJugador1]}-{nombres[puntosJugador2]}";
        }

        return string.Empty;
    }
}