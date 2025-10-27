using FluentAssertions;

namespace ValidacionDeContrasena;

public class ValidacionDeContrasena
{
    [Fact]
    public void Si_EnvioCualquierContraseñaValida_DebeRetornarVerdadero()
    {
        // Arrange

        // Act
        var esValida = ValidaContrasena("Julia_n1234");
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
        var esValida = ValidaContrasena(contrasena);

        // Assert
        esValida.Should().Be(valorEsperado);
    }
    
    private static bool ValidaContrasena(string contrasena)
    {
        var contieneMayuscula = contrasena.Any(char.IsUpper);
        var contieneMinuscula = contrasena.Any(char.IsLower);
        var contieneNumero = contrasena.Any(char.IsDigit);
        var contieneGuionBajo = contrasena.Contains('_');

        return contrasena.Length >= 8 && contieneMayuscula && contieneMinuscula && contieneNumero && contieneGuionBajo;
    }
}