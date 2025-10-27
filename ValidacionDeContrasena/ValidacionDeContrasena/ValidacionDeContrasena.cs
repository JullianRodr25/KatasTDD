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

    private static object ValidaContrasena(string contrasena)
    {
        return true;
    }

}