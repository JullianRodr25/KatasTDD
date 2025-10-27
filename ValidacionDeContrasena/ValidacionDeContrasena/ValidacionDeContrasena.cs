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

    [Fact]
    public void Si_EnvioUnaContraseñaYNoContieneUnaLetraMayuscula_Debe_RetornarFalso()
    {
        // Arrange

        // Act
        var esValida = ValidaContrasena("prueba1234");

        // Assert
        esValida.Should().Be(false);
    }
    
    
    [Fact]
    public void Si_EnvioUnaContraseñaYNoContieneUnaLetraMinuscula_Debe_RetornarFalso()
    {
        // Arrange

        // Act
        var esValida = ValidaContrasena("PRUEBA1234");

        // Assert
        esValida.Should().Be(false);
    }
    [Fact]
    public void Si_EnvioUnaContraseñaSinNumero_Debe_RetornarFalso()
    {
        // Arrange

        // Act
        var esValida = ValidaContrasena("Password");

        // Assert
        esValida.Should().Be(false);
    }
    

    private static object ValidaContrasena(string contrasena)
    {
        var contieneMayuscula = contrasena.Any(char.IsUpper);
        var contieneMinuscula = contrasena.Any(char.IsLower);

        return contrasena.Length >= 8 && contieneMayuscula && contieneMinuscula;
    }
}