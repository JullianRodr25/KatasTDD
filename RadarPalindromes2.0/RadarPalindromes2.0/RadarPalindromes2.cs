using FluentAssertions;

namespace RadarPalindromes2._0;

public class RadarPalindromes2
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
    
    private bool EsPalindromo(string cadena)
    {
        return cadena == "" ? false : throw new NotImplementedException();
    }
}