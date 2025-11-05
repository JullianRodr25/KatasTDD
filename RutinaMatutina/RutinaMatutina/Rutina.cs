namespace RutinaMatutina;

public class Rutina
{
    private readonly List<Actividad> _actividades;

    public Rutina()
    {
        _actividades =
        [
            new Actividad("Ducharse", new TimeSpan(6, 45, 0), new TimeSpan(6, 50, 00)),
            new Actividad("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 59)),
            new Actividad("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 59, 59)),
            new Actividad("Leer y estudiar", new TimeSpan(7, 0, 0), new TimeSpan(7, 59, 59)),
            new Actividad("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 59)),
         
        ];
    }


    public string QueHagoAhora(DateTime horaActual)
    {
        var hora = horaActual.TimeOfDay;
        var actividad = _actividades.FirstOrDefault(a => a.EstaEnRango(hora));
        return actividad?.Descripcion ?? "Sin actividad";
    }
}

internal class Actividad
{
    public string Descripcion { get; }
    public TimeSpan HoraInicio { get; }
    public TimeSpan HoraFin { get; }

    public Actividad(string descripcion, TimeSpan horaInicio, TimeSpan horaFin)
    {
        Descripcion = descripcion;
        HoraInicio = horaInicio;
        HoraFin = horaFin;
    }

    public bool EstaEnRango(TimeSpan horaActual)
    {
        return horaActual >= HoraInicio && horaActual <= HoraFin;
    }
}