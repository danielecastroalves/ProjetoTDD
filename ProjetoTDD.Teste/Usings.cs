global using Xunit;
global using ProjetoTDD.Lib;


/*
OBSERVAÇÕES GERAIS

Para que a biblioteca do xUnit reconheça o método como um teste, é necessário sinalizar com uma anotação acima do método.

- O atributo `[Fact]` declara um método de teste que é executado pelo executor de testes.
- O `[Theory]` representa um pacote de testes que executa o mesmo código, mas têm diferentes argumentos de entrada.
- O atributo `[InlineData]` especifica valores para essas entradas.   
  
  
 */