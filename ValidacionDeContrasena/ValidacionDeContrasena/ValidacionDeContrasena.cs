using FluentAssertions;

namespace ValidacionDeContrasena;

public class ValidacionDeContrasena
{
    [Fact]
    public void Si_EnvioCualquierContraseña_DebeRetornarVerdadero()
    {
        // Arrange
        
        // Act
        var esValida = ValidaContrasena("Julian1234");
        // Assert

        esValida.Should().Be(true);
        
    }
    
    [Fact]
    public void Si_EnvioUnaContraseñaConMenosDeOchoCaracteres_Debe_RetornarFalso()
    {
        // Arrange
        
        // Act
        var esValida = ValidaContrasena("abc");
        
        // Assert
        esValida.Should().Be(false);
    }

    private static object ValidaContrasena(string contrasena)
    {
        if (contrasena.Length < 8)
            return false;
        return true;
    }

}