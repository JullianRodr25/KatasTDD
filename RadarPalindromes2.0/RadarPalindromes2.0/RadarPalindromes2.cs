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
    
    [Fact]
    public void Si_EnvioUnaSolaLetra_DebeRetornarVerdadero()
    {
        // Arrage
        // Act
        var resultado = EsPalindromo("a");
        // Assert
        resultado.Should().BeTrue();
    }
    
    private bool EsPalindromo(string cadena)
    {
        if (cadena == "")
            return false;

        if (cadena.Length == 1)
            return true;
        
        throw new NotImplementedException();

    }
}