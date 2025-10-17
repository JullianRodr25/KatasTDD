using FluentAssertions;

namespace AñoBisiesto;

public class AnioBisiesto
{
    [Theory]
    [InlineData(1569)]
    [InlineData(1701)]
    [InlineData(2019)]
    [InlineData(2023)]
    public void Si_ElAnioNoEsDivisiblePorCuatro_Deberia_SerFalso(int anio)
    {
        var resultado = EsAnioBisiesto(anio);
        resultado.Should().BeFalse();
    }

    [Theory]
    [InlineData(2008)]
    [InlineData(2004)]
    [InlineData(2012)]
    public void Si_ElAnioEsDivisiblePorCuatro_Deberia_SerVerdadero(int anio)
    {
        var resultado = EsAnioBisiesto(anio);
        resultado.Should().Be(true);
    }

    [Theory]
    [InlineData(1700)]
    [InlineData(1800)]
    [InlineData(1900)]
    [InlineData(2100)]
    public void Si_ElAnioEsDivisiblePorCienYNoPorCuatrocientos_Deberia_RetornarFalso(int anio)
    {
        var resultado = EsAnioBisiesto(anio);
        resultado.Should().BeFalse();
    }
    
    private static bool EsAnioBisiesto(int anio)
    {
        if (anio % 4 != 0)
            return false;
        return anio % 100 != 0 || anio % 400 == 0;
    }
}