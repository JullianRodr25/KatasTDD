using FluentAssertions;

namespace NumerosRomanos;

public class NumerosRomanosTest
{
    [Fact]
    public void Si_EnvioElNumero1_DebeRetonarElEquivalenteARomanoI()
    {
        // Act
        var noRomano = new NumeroRomanos();
        // Assert
        noRomano.ConvertirANumeroRomano(1).Should().Be("I");
    }

    [Fact]
    public void Si_EnvioElNumero2_DebeRetonarElEquivalenteARomanoII()
    {
        // Act
        var noRomano = new NumeroRomanos();
        // Assert
        noRomano.ConvertirANumeroRomano(2).Should().Be("II");
    }

    [Fact]
    public void Si_EnvioElNumero3_DebeRetonarElEquivalenteARomanoIII()
    {
        // Act
        var noRomano = new NumeroRomanos();
        // Assert
        noRomano.ConvertirANumeroRomano(3).Should().Be("III");
    }
}

public class NumeroRomanos
{
    public string ConvertirANumeroRomano(int numeroArabigo)
    {
        return numeroArabigo switch
        {
            1 => "I",
            2 => "II",
            _ => "III"
        };
    }
}