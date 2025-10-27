using FluentAssertions;

namespace ValidacionDeContrasena;

public class UnitTest1
{
    [Fact]
    public void Si_EnvioCualquierContraseña_DebeRetornarVerdadero()
    {
        // Arrange
        
        // Act
        var esValida = validaContrasena("Julian1234");
        // Assert

        esValida.Should().Be(true);



    }

    private object validaContrasena(string julian1234)
    {
        return true;
    }

}