global using Xunit;
global using ProjetoTDD.Lib;


/*
OBSERVA��ES GERAIS

Para que a biblioteca do xUnit reconhe�a o m�todo como um teste, � necess�rio sinalizar com uma anota��o acima do m�todo.

- O atributo `[Fact]` declara um m�todo de teste que � executado pelo executor de testes.
- O�`[Theory]`�representa um pacote de testes que executa o mesmo c�digo, mas t�m diferentes argumentos de entrada.
- O atributo�`[InlineData]`�especifica valores para essas entradas.   
  
  
 */