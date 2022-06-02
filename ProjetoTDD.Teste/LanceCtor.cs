
namespace ProjetoTDD.Teste
{
    public class LanceCtor
    {
        //Classe criada para testar o construtor
        //Observe que o nome dessa classe de testes é igual ao nome da classe que será testada + nome do método testado
        //Lance + Construtor = LanceCtor
        //Logo abaixo o método de testes é nomeado de acordo com o comportamento esperado pelo cenário

        //A anotação [Fact] é usada pois não há necessidade de se montar um cenário prévio
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Ao criar um novo objeto do tipo Lance
            //Deverá lançar uma exceção caso valor seja negativo

            //Arranje - cenário a ser testado
            var valorNegativo = -100;            

            //Assert - Verificação dos resultados
            Assert.Throws<System.ArgumentException>(
                //Act - Método a ser testado
                () => new Lance(null, valorNegativo)
            );
        }
    }
}
