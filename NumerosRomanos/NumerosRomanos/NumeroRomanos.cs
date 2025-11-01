namespace NumerosRomanos;

public class NumeroRomanos
{
    public string ConvertirANumeroRomano(int numeroArabigo)
    {
        var mapa = new (int Valor, string Simbolo)[]
        {
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var resultado = "";

        foreach (var (valor, simbolo) in mapa)
        {
            while (numeroArabigo >= valor)
            {
                resultado += simbolo;
                numeroArabigo -= valor;
            }
        }

        return resultado;
    }
}