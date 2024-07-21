namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange: serve para montar o cen�rio de testes
        int num1 = 5;
        int num2 = 10;

        // Act: chamar o cen�rio para executar uma a��o. Neste caso, a a��o � de somar
        int resultado = _calc.Somar(num1, num2);

        // Assert: valida o resultado da a��o
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair20de40ERetornar20()
    {
        // Arrange
        int num1 = 40;
        int num2 = 20;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        // Theory: � um conjunto de cen�rios. No "InlineData" � passado um par�metro como cen�rio de um teste. Funciona como um la�o de repeti��o,
        // sem ter a necessidade de escrever v�rios testes para cada um dos cen�rios.
        // D� para reaproveitar testes

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveVerificarSeOsNumerosDoArraySaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Com o Theory tamb�m � poss�vel receber cole��es como cen�rio, para serem verificadas

        // Act e Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}