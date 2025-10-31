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
    public object ConvertirANumeroRomano(int i)
    {
        throw new NotImplementedException();
    }
}


