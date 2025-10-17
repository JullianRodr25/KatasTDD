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

    [Fact]
    public void Si_EnvioUnNumero_Debe_RetornarElMismoNumero()
    {
        var resultado = retornaNumeroCero("4");
        resultado.Should().Be(4);
        
    }

    private object retornaNumeroCero(string valor)
    {
        return valor == "" ? 0 : valor;
    }
}