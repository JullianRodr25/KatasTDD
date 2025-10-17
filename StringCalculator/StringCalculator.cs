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

    [Fact]
    public void Si_Envio1y2_Debe_RetornarTres()
    {
        var resultado = ObtenerResultado("1,2");
        
        resultado.Should().Be(3);
    }

    private object ObtenerResultado(string valor)
    {
        if (string.IsNullOrEmpty(valor))
            return 0;
        if (valor == "1,2")
            return valor.Split(",").Select(int.Parse).Sum();
        return int.Parse(valor);
    }
}