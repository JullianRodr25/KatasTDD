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
    [InlineData(9, "IX")]
    
    public void Si_EnvioUnNumeroArabigo_Debe_RetornarElEquivalenteCorrectoRomano(int numeroArabigo, string esperado)
    {
        // Arrange
        var noRomano = new NumeroRomanos();

        // Act
        var resultado = noRomano.ConvertirANumeroRomano(numeroArabigo);

        // Assert
        resultado.Should().Be(esperado);
    }
    
}