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
    
    [Fact]
    public void Si_EnvioElNumero4_DebeRetonarElEquivalenteARomanoIV()
    {
        // Act
        var noRomano = new NumeroRomanos();
        // Assert
        noRomano.ConvertirANumeroRomano(4).Should().Be("IV");
    }
    
    [Fact]
    public void Si_EnvioElNumero5_DebeRetonarElEquivalenteARomanoV()
    {
        // Act
        var noRomano = new NumeroRomanos();
        // Assert
        noRomano.ConvertirANumeroRomano(5).Should().Be("V");
    }
    
    
}

public class NumeroRomanos
{
    public string ConvertirANumeroRomano(int numeroArabigo)
    {
        if (numeroArabigo == 4)
            return "IV";
        if (numeroArabigo == 5)
            return "V";

        return new string('I', numeroArabigo);
    }
}