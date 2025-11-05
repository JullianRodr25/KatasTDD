namespace RutinaMatutina;

public class Rutina
{
    public string QueHagoAhora(DateTime horaActual)
    {
        var hora = horaActual.Hour;
        if (hora == 6 )
            return "Hacer ejercicio";
        if (hora == 7)
            return "Leer y estudiar";
        if (hora == 8)
            return "Desayunar";
        return "Sin actividad";
    }
}