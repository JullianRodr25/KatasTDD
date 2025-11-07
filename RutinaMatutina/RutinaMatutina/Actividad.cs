namespace RutinaMatutina;

public class Actividad
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