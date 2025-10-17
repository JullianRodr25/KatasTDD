using FluentAssertions;

namespace StringCalculator;

public class StringCalculator
{
    [Fact]
    public void Si_EnvioVacio_Debe_RetornarCero()
    {
        var resultado = ObtenerResultado("");
        resultado.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("4", 4)]
    [InlineData("6", 6)]
    public void Si_EnvioUnNumero_Debe_RetornarElMismoNumero(string valorIngreso, int valorEsperado)
    {
        var resultado = ObtenerResultado(valorIngreso);
        
        resultado.Should().Be(valorEsperado);
    }

    private object ObtenerResultado(string valor)
    {
        return string.IsNullOrEmpty(valor) ? 0 : int.Parse(valor);
    }
}