namespace RutinaMatutina;

public class Rutina
{
    private readonly List<Actividad> _actividades;

    public Rutina()
    {
        _actividades =
        [
            new Actividad("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 59, 59)),
            new Actividad("Leer y estudiar", new TimeSpan(7, 0, 0), new TimeSpan(7, 59, 59)),
            new Actividad("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 59)),
            new Actividad("Ducharse", new TimeSpan(6, 45, 0), new TimeSpan(6, 50, 00)),

        ];
    }
    
    public string QueHagoAhora(DateTime horaActual)
    {
        var hora = horaActual.TimeOfDay;
        var actividad = _actividades
            .Where(a => a.EstaEnRango(hora))
            .OrderByDescending(a => a.HoraInicio)
            .FirstOrDefault();
        return actividad?.Descripcion ?? "Sin actividad";
    }
}