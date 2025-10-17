using System.Text.RegularExpressions;
using FluentAssertions;

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
    public void Si_EnvioMultiplesNumerosSeparadosPorcualquierSeparadorDeCaracteres_Debe_RetornarLaSuma(string ValorIngresado, int ValorEsperado)
    {
        var resultado = ObtenerSuma(ValorIngresado);
        resultado.Should().Be(ValorEsperado);
    }

    [Fact] public void Si_EnvioMenosUno_Debe_RetornarUnMensajeDeError()
    {
        var resultado = () => ObtenerSuma("-1");
        resultado.Should().Throw<ArgumentException>().WithMessage("Los negativos no son permitidos: -1");
    }


    private static int ObtenerSuma(string cadena)
    {
        return string.IsNullOrEmpty(cadena) ? 0 : ExtraerYSumarNumeros(cadena);
    }

    private static int ExtraerYSumarNumeros(string cadena)
         {
             var numeros = Regex.Matches(cadena, @"\d+")
                 .Select(m => int.Parse(m.Value))
                 .ToList();
     
             return numeros.Sum();
         }
}