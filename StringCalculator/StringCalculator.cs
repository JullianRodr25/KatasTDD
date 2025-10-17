using FluentAssertions;

namespace StringCalculator;

public class StringCalculator
{
    [Fact]
    public void Si_EnvioVacio_Debe_RetornarCero()
    {
        var resultado = CalcularSuma("");
        resultado.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("4", 4)]
    [InlineData("6", 6)]
    public void Si_EnvioUnNumero_Debe_RetornarElMismoNumero(string valorIngreso, int valorEsperado)
    {
        var resultado = CalcularSuma(valorIngreso);
        
        resultado.Should().Be(valorEsperado);
    }
    
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("1,2,3", 6)]
    public void Si_EnvioMultiplesNumerosSeparadosPorComa_Debe_RetornarLaSuma(string ValorIngreso, int ValorEsperado)
    {
        var resultado = CalcularSuma(ValorIngreso);
        resultado.Should().Be(ValorEsperado);
    }

    private static int CalcularSuma(string valor)
    {
        if (string.IsNullOrEmpty(valor))
            return 0;
        return valor.Length > 1 ? valor.Split(",").Select(int.Parse).Sum() : int.Parse(valor);
    }
}