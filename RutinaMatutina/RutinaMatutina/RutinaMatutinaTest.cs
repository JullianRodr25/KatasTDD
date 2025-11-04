namespace RutinaMatutina;

public class RutinaMatutinaTest
{
    [Fact]
    public void Si_SonLas6DeLaMañana_Debe_RetornarHacerEjecicio()
    {
        // Arrange
        var rutina = new Rutina();
        var hora = new DateTime(2025, 1, 1, 6, 00, 00);

        // Act
        var resultado = rutina.QueHagoAhora(hora);

        // Assert
        Assert.Equal("Hacer ejercicio", resultado);
    }
    
    [Fact]
    public void Si_SonLas7DeLaMañana_Debe_RetornarLeerYEstudiar()
    {
        // Arrange
        var rutina = new Rutina();
        var hora = new DateTime(2025, 1, 1, 7, 00, 00);

        // Act
        var resultado = rutina.QueHagoAhora(hora);

        // Assert
        Assert.Equal("Leer y estudiar", resultado);
    }
}

public class Rutina
{
    public string QueHagoAhora(DateTime hora)
    {
        if (hora.Hour == 6 )
            return "Hacer ejercicio";
        if (hora.Hour == 7)
            return "Leer y estudiar";
        return "Sin actividad";
    }
}