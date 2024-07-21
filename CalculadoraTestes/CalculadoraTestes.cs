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
        // Arrange: serve para montar o cenário de testes
        int num1 = 5;
        int num2 = 10;

        // Act: chamar o cenário para executar uma ação. Neste caso, a ação é de somar
        int resultado = _calc.Somar(num1, num2);

        // Assert: valida o resultado da ação
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
        // Theory: é um conjunto de cenários. No "InlineData" é passado um parâmetro como cenário de um teste. Funciona como um laço de repetição,
        // sem ter a necessidade de escrever vários testes para cada um dos cenários.
        // Dá para reaproveitar testes

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
        // Com o Theory também é possível receber coleções como cenário, para serem verificadas

        // Act e Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}