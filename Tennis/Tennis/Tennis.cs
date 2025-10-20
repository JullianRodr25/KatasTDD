using FluentAssertions;

namespace Tennis;

public class Tennis
{

    [Fact]
    public void Si_AmbosJugadoresTienenCeroPuntos_RegresaLove()
    {
        var resultado = CalcularPuntajeTennis(0,0);
        
        resultado.Should().Be("Love");

        
    }

    private object CalcularPuntajeTennis(int player1, int player21)
    {
        throw new NotImplementedException();
    }
}