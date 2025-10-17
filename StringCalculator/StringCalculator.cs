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
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void Si_EnvioMultiplesNumerosSeparadosPorComa_Debe_RetornarLaSuma(string ValorIngreso, int ValorEsperado)
    {
        var resultado = CalcularSuma(ValorIngreso);
        resultado.Should().Be(ValorEsperado);
    }

    [Fact]
    public void Si_EnvioMultiplesNumerosSeparadosEspacios_Debe_RetornarLaSuma()
    {
        var resultado = CalcularSuma("1 2");
        resultado.Should().Be(3);
    }
    
    [Fact]
    public void Si_EnvioMultiplesNumerosSeparadosPorcualquierSeparadorDeCaracteres_Debe_RetornarLaSuma()
    {
        var resultado = CalcularSuma("//;\n2;2");
        resultado.Should().Be(4);
    }
    

    private static int CalcularSuma(string valor)
    {
        if (string.IsNullOrEmpty(valor))
            return 0;

        char[] separadores = [',', ' '];

        if (valor.StartsWith("//"))
        {
            var delimitador = valor[2];
            valor = valor.Substring(4);
            separadores = [delimitador];
        }

        return valor
            .Split(separadores, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Sum();
    }
}