using FluentAssertions;

namespace StringCalculator;

public class StringCalculator
{
    [Fact]
    public void Si_EnvioVacio_Debe_RetornarCero()
    {
        var resultado = retornaNumeroCero("");
        resultado.Should().Be(0);
    }

    private object retornaNumeroCero(string empty)
    {
        throw new NotImplementedException();
    }
}