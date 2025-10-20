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

    private static string CalcularPuntajeTennis(int player1, int player2)
    {
        if (player1 == 0 && player2 == 0)
        return "Love";
    }
}