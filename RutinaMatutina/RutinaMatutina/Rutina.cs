namespace RutinaMatutina;

public class Rutina
{
    private readonly List<Actividad> _actividades;

    public Rutina(List<Actividad> actividades)
    {
        _actividades = actividades;
    }
    
    public string ObtenerActividadPara(DateTime horaActual)
    {
        var hora = horaActual.TimeOfDay;
        var actividad = _actividades.FirstOrDefault(a => a.EstaEnRango(hora));
        return actividad?.Descripcion ?? "Sin actividad";
    }
}