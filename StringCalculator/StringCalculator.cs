using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{
    [Fact]
    public void Si_EnvioVacio_Debe_RetornarCero()
    {
        var resultado = ObtenerSuma("");
        resultado.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("4", 4)]
    [InlineData("6", 6)]
    public void Si_EnvioUnNumero_Debe_RetornarElMismoNumero(string valorIngresado, int valorEsperado)
    {
        var resultado = ObtenerSuma(valorIngresado);

        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void Si_EnvioMultiplesNumerosSeparadosPorComa_Debe_RetornarLaSuma(string ValorIngreso, int ValorEsperado)
    {
        var resultado = ObtenerSuma(ValorIngreso);
        resultado.Should().Be(ValorEsperado);
    }

    [Fact]
    public void Si_EnvioMultiplesNumerosSeparadosEspacios_Debe_RetornarLaSuma()
    {
        var resultado = ObtenerSuma("1 2");
        resultado.Should().Be(3);
    }

    [Theory]
    [InlineData("\"//;\\n1;2", 3)]
    [InlineData("1\n2,3", 6)]
    [InlineData("2,\\n2", 4)]
    public void Si_EnvioMultiplesNumerosSeparadosPorcualquierSeparadorDeCaracteres_Debe_RetornarLaSuma(
        string ValorIngresado, int ValorEsperado)
    {
        var resultado = ObtenerSuma(ValorIngresado);
        resultado.Should().Be(ValorEsperado);
    }

    [Fact]
    public void Si_EnvioMenosUno_Debe_RetornarUnMensajeDeError()
    {
        var resultado = () => ObtenerSuma("-1");
        resultado.Should().Throw<ArgumentException>().WithMessage("Los negativos no son permitidos: -1");
    }

    [Fact]
    public void Si_EnvioEnLacadenaNumerosNegativos_Debe_RetornarUnMensajeDeError()
    {
        var resultado = () => ObtenerSuma("1,-2,-3");
        resultado.Should().Throw<ArgumentException>().WithMessage("Los negativos no son permitidos: -2,-3");
    }


    private static int ObtenerSuma(string cadena)
    {
        if (string.IsNullOrEmpty(cadena))
            return 0;

        var numeros = ExtraerNumeros(cadena);
        var negativos = new List<int>();

        foreach (var n in numeros)
        {
            if (n < 0)
                negativos.Add(n);
        }

        if (negativos.Count > 0)
            throw new ArgumentException("Los negativos no son permitidos: " + string.Join(",", negativos));

        return numeros.Sum();
    }

    private static List<int> ExtraerNumeros(string cadena)
    {
        var matches = Regex.Matches(cadena, @"-?\d+");
        var numeros = new List<int>();
        foreach (Match match in matches)
        {
            numeros.Add(int.Parse(match.Value));
        }
        return numeros;
    }
}