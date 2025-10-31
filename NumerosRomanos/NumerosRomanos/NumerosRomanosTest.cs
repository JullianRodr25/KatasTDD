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
}
 
public class NumeroRomanos
{
    public string  ConvertirANumeroRomano(int i)
    {
        return "I";
    }
}


