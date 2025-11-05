namespace RutinaMatutina;

public class Rutina
{
    public string QueHagoAhora(DateTime horaActual)
    {
        var hora = horaActual.TimeOfDay;

        if (hora >= new TimeSpan(6, 0, 0) && hora < new TimeSpan(6, 50, 0))
            return "Hacer ejercicio";

        if (hora >= new TimeSpan(6, 50, 0) && hora < new TimeSpan(7, 0, 0))
            return "Ducharse";

        if (hora >= new TimeSpan(7, 0, 0) && hora < new TimeSpan(8, 0, 0))
            return "Leer y estudiar";

        if (hora >= new TimeSpan(8, 0, 0) && hora < new TimeSpan(9, 0, 0))
            return "Desayunar";

        return "Sin actividad";
    }
}