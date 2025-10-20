using FluentAssertions;

namespace Tennis;

public class Tennis
{
    [Theory]
    [InlineData(0, 0, "Love-All")]
    [InlineData(1, 1, "Fifteen-All")]
    [InlineData(2, 1, "Thirty-Fifteen")]
    [InlineData(2, 2, "Thirty-All")]
    [InlineData(3, 2, "Forty-Thirty")]
    public void
        Si_Jugador1YJugador2TieneLosMismosResultadosMenoresDe4DeberiaRetornarLoveAlloFifteenAlloThirtyAlloFortyAll(
            int puntosJugador1, int puntosJugador2, string resultadoEsperado)
    {
        var resultado = CalcularPuntajeTennis(puntosJugador1, puntosJugador2);

        resultado.Should().Be(resultadoEsperado);
    }

    [Theory]
    [InlineData(3, 3, "Deuce")]
    [InlineData(4, 4, "Deuce")]
    public void Si_Jugador1TieneTresPuntosYJugador2Tres_Debe_RetornarDeuce(int puntosJugador1, int puntosJugador2,
        string resultadoEsperado)
    {
        var resultado = CalcularPuntajeTennis(puntosJugador1, puntosJugador2);

        resultado.Should().Be(resultadoEsperado);
    }

    [Theory]
    [InlineData(4, 3, "Advantage jugador 1")]
    [InlineData(3, 4, "Advantage jugador 2")]
    public void
        Si_AmbosJugadoresTienenAlMenosTresPuntosYUnoTieneUnoMas_DeberiaRetornarAdvantageJugador1oAdvantageJugador2(
            int puntosJugador1, int puntosJugador2, string resultadoEsperado)
    {
        var resultado = CalcularPuntajeTennis(puntosJugador1, puntosJugador2);

        resultado.Should().Be(resultadoEsperado);
    }

    [Theory]
    [InlineData(4, 0, "Gana jugador 1")]
    [InlineData(0, 4, "Gana jugador 2")]
    [InlineData(2, 4, "Gana jugador 2")]
    public void Si_UnJugadorTieneAlMenosCuatroPuntosYDosMasQueElOtro_DeberiaRetornarGanaJugador(int puntosJugador1,
        int puntosJugador2, string resultadoEsperado)
    {
        var resultado = CalcularPuntajeTennis(puntosJugador1, puntosJugador2);

        resultado.Should().Be(resultadoEsperado);
    }
    
    private static string CalcularPuntajeTennis(int puntosJugador1, int puntosJugador2)
    {
        string[] nombres = { "Love", "Fifteen", "Thirty", "Forty" };

        if (puntosJugador1 == puntosJugador2)
            return ObtenerMarcadorEmpate(puntosJugador1, nombres);

        if (puntosJugador1 >= 4 || puntosJugador2 >= 4)
            return ObtenerMarcadorFinal(puntosJugador1, puntosJugador2);

        return $"{nombres[puntosJugador1]}-{nombres[puntosJugador2]}";
    }

    private static string ObtenerMarcadorEmpate(int puntos, string[] nombres)
    {
        return puntos >= 3 ? "Deuce" : $"{nombres[puntos]}-All";
    }

    private static string ObtenerMarcadorFinal(int puntosJugador1, int puntosJugador2)
    {
        int diferencia = puntosJugador1 - puntosJugador2;

        if (Math.Abs(diferencia) >= 2)
            return diferencia > 0 ? "Gana jugador 1" : "Gana jugador 2";

        return diferencia > 0 ? "Advantage jugador 1" : "Advantage jugador 2";
    }
}