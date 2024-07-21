using System;

public class ValidacoesStringsTestes
{
	private ValidacoesString _validacoesString;

	public ValidacoesStringsTestes()
	{
		_validacoesString = new ValidacoesString();
	}

	[Fact]
	public void DeveContar3CaracteresEmOlaERetornar3()
	{
		// Arrange
		string texto = "Olá";

		// Act
		int resultado = _validacoesString.ContarCaracteres(texto);

		// Assert
		Assert.Equal(3, resultado);
	}
}
