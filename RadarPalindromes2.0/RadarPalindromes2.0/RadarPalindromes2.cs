using FluentAssertions;

namespace RadarPalindromes2._0;

public class RadarPalindromes2
{
    [Fact]
    public void Si_EnvioUnaCadenaVacia_Debe_RetornarFalso()
    {
        // Arrage

        // Act
        var resultado = EsPalindromo("");

        // Assert
        resultado.Should().Be(false);
    }

    [Theory]
    [InlineData("a", true)]
    [InlineData("d", true)]
    [InlineData("j", true)]
    public void Si_EnvioUnaSolaLetra_DebeRetornarVerdadero(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("AnNa.", true)]
    [InlineData("ANNA", true)]
    [InlineData("annA", true)]
    public void Si_EnvioAnNa_DebeIgnorarMayusculasYRetornarVerdadero(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("A nna", true)]
    [InlineData("   anna", true)]
    [InlineData("anna   ", true)]
    public void Si_EnvioAnnaDejandoEspacios_DebeIgnorarlosYRetornarVerdadero(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("Anna.", true)]
    [InlineData("An.na", true)]
    [InlineData(".A.nna.", true)]
    public void Si_EnvioAnnaConPuntuacion_DebeIgnorarLaPuntuacionyRetornarVerdadero(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }

    [Theory]
    [InlineData("Prueba", false)]
    [InlineData("Hola", false)]
    [InlineData("123", false)]
    public void Si_EnvioUnaPalabraQueNoEsPalindromo_DebeRetornarFalso(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }
    
    [Theory]
    [InlineData("12321", true)]
    [InlineData("33", true)]
    [InlineData("11", true)]
    public void Si_EnvioUnaCadenaConNumerosDebeTratarlosComoTexto(string cadena, bool valorEsperado)
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo(cadena);
        // Assert
        resultado.Should().Be(valorEsperado);
    }

    private bool EsPalindromo(string cadena)
    {
        if (string.IsNullOrEmpty(cadena))
            return false;

        var cadenaMin = new string(cadena
            .ToLower()
            .Where(char.IsLetterOrDigit)
            .ToArray());

        var inversa = new string(cadenaMin.Reverse().ToArray());

        return cadenaMin == inversa;
    }
}