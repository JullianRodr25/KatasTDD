using FluentAssertions;

namespace ValidacionDeContrasena;

public class ValidacionDeContrasena
{
    [Fact]
    public void Si_EnvioCualquierContraseñaValida_DebeRetornarVerdadero()
    {
        // Arrange

        // Act
        var esValida = Validador.ValidaContrasena("Julia_n1234", 1);
        // Assert

        esValida.Should().Be(true);
    }
    
    [Theory]
    [InlineData("abc", false)]
    [InlineData("prueba1234", false)]
    [InlineData("PRUEBA1234", false)]
    [InlineData("Password", false)]
    [InlineData("Prueba1234", false)]
    
    public void Si_EnvioUnaContraseñaIncorrecta_Debe_RetornarFalso(string contrasena, bool valorEsperado)
    {
        // Arrange

        // Act
        var esValida = Validador.ValidaContrasena(contrasena, 1);

        // Assert
        esValida.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_EnvioUnaContraseñaConMasDeSeisCaracteresYSinguionBajo_Debe_RetornarVerdadero()
    {
        // Arrange

        // Act
        var esValida = Validador.ValidaContrasena("Prueb12", 2);


        // Assert
        esValida.Should().Be(true);
    }
}