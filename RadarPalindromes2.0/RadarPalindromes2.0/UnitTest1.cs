using FluentAssertions;

namespace RadarPalindromes2._0;

public class UnitTest1
{
    [Fact]
    public void Si_EnvioUnaCadenaVacia_Debe_RetornarFalse()
    {
        // Arrage
        
        // Act
        var resultado = EsPalindromo("");

        // Assert
        resultado.Should().Be(false);
        
    }

    private object EsPalindromo(string cadena)
    {
        return false;
    }
}