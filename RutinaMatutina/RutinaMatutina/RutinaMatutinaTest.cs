namespace RutinaMatutina;

public class RutinaMatutinaTest
{
    private readonly Rutina _rutina = new([
        new Actividad("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 59, 59)),
        new Actividad("Leer y estudiar", new TimeSpan(7, 0, 0), new TimeSpan(7, 59, 59)),
        new Actividad("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 59)),
        new Actividad("Ducharse", new TimeSpan(6, 45, 0), new TimeSpan(6, 50, 0))
    ]);

    [Fact]
    public void Si_SonLas6DeLaMañana_Debe_RetornarHacerEjecicio()
    {
        // Arrange
        var hora = new DateTime(2025, 1, 1, 6, 00, 00);

        // Act
        var resultado = _rutina.ObtenerActividadPara(hora);

        // Assert
        Assert.Equal("Hacer ejercicio", resultado);
    }

    [Fact]
    public void Si_SonLas7DeLaMañana_Debe_RetornarLeerYEstudiar()
    {
        // Arrange

        var hora = new DateTime(2025, 1, 1, 7, 00, 00);

        // Act
        var resultado = _rutina.ObtenerActividadPara(hora);

        // Assert
        Assert.Equal("Leer y estudiar", resultado);
    }


    [Fact]
    public void Si_SonLas8DeLaMañana_Debe_RetornarDesayunar()
    {
        // Arrange
        var hora = new DateTime(2025, 1, 1, 8, 00, 00);

        // Act
        var resultado = _rutina.ObtenerActividadPara(hora);

        // Assert
        Assert.Equal("Desayunar", resultado);
    }
    
    [Fact]
    public void Si_SonLas6Y50DeLaMañana_Debe_RetornarDucharse()
    {
        // Arrange
        var actividades = new List<Actividad>
        {
            new("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 44, 00)),
            new("Ducharse", new TimeSpan(6, 45, 0), new TimeSpan(6, 59, 59)),
        };
        var rutina = new Rutina(actividades);
        var hora = new DateTime(2025, 1, 1, 6, 50, 00);

        // Act
        var resultado = rutina.ObtenerActividadPara(hora);

        // Assert
        Assert.Equal("Ducharse", resultado);
    }

    
}