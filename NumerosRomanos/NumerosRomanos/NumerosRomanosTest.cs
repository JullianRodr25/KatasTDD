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
}
 
public class NumeroRomanos
{
    public string  ConvertirANumeroRomano(int i)
    {
        return "I";
    }
}


