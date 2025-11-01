using FluentAssertions;

namespace NumerosRomanos;

public class NumerosRomanosTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    
    public void ConvertirANumeroRomano_DeberiaRetornarElEquivalenteCorrecto(int numeroArabigo, string esperado)
    {
        // Arrange
        var noRomano = new NumeroRomanos();

        // Act
        var resultado = noRomano.ConvertirANumeroRomano(numeroArabigo);

        // Assert
        resultado.Should().Be(esperado);
    }

    [Fact]
    public void Si_EnvioElNumero9_Debe_RetornarElEquivalenteNumeroRomanoIX()
    {
        // Arrange
        var noRomano = new NumeroRomanos();

        // Act
        var resultado = noRomano.ConvertirANumeroRomano(9);

        // Assert
        resultado.Should().Be("IX");
    }
    
}

public class NumeroRomanos
{
    public string ConvertirANumeroRomano(int numeroArabigo)
    {
        var mapa = new (int Valor, string Simbolo)[]
        {
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var resultado = "";

        foreach (var (valor, simbolo) in mapa)
        {
            while (numeroArabigo >= valor)
            {
                resultado += simbolo;
                numeroArabigo -= valor;
            }
        }

        return resultado;
    }
}