# ProjetoTDD

Projeto criado com base no curso da Alura - C#: Testes de unidade e TDD com xUnit.

O Objetivo desse projeto é exemplificar os casos de testes unitários em uma aplicação.


# O que são Testes Unitários?

Testes Unitários são testes das menores partes testáveis de um programa, por exemplo:

- **Linguagem Orientada a Objetos:** métodos do objeto
- **Linguagem Funcional:** teste de uma função

# Para que servem?

Os testes são úteis para garantir que seu programa continue funcionando mesmo após alterações no código.

# Por que escrever testes?

Normalmente o tempo de **manutenção** é muito maior do que o de **desenvolvimento** e ter uma **automação para testes** de grandes sistemas faz todo sentido para melhorar a qualidade do código.

Conforme o sistema se desenvolve e cresce, com os testes unitários implementados, garantimos que a manutenção não seja tão árdua e que o software continue estável.

Ou seja, aumenta a produtividade e a qualidade, diminui os custos de manutenção do sistema e o retrabalho.

# Montando a arquitetura usando xUnit em .Net Core

Para começar a desenvolver os testes unitários, é necessário criar um projeto de testes:

- `Projeto de Teste do xUnit (.NET Core)`

Se não tiver esse template de projeto instalado abra o menu `Ferramentas\Extensões e Atualizações`  e procure pela extensão **Microsoft Visual Studio Test Platform**. Em seguida basta instalá-la ou habilitá-la.

Devemos organizar os testes automatizados em três sessões funcionais chamadas **AAA:**

- **`Arrange`** - Arranjar todas as pré-condições de entrada ou o cenário
- **`Act`** - Método a ser testado
- **`Assert`** - Verificar os resultados

http://wiki.c2.com/?ArrangeActAssert

Também temos uma maneira muito conhecida e equivalente ao AAA que é o `Given`, `When`, `Then` estabelecido por Martin Fowler que pode ser exemplicada como:

- **`Given`** - Dado o seguinte cenário - Dado que tenho um lance de 1000 reais e outro de 1200 reais
- **`When`** - Quando encerro o pregão
- **`Then`** - Então o lance maior será o ganhador do leilão, no caso será 1200 reais

https://martinfowler.com/bliki/GivenWhenThen.html

## Nomenclatura das classes e métodos de testes

O nome do seu teste deve ser composto por três partes:

- O nome do método que está sendo testado.
- O cenário em que ele está sendo testado.
- O comportamento esperado quando o cenário é invocado.

## Declarando os testes 

Para que a biblioteca do xUnit reconheça o método como um teste, é necessário sinalizar com uma anotação acima do método.

- O atributo `[Fact]` declara um método de teste que é executado pelo executor de testes.
- O `[Theory]` representa um pacote de testes que executa o mesmo código, mas têm diferentes argumentos de entrada.
- O atributo `[InlineData]` especifica valores para essas entradas.

## ****Comparando xUnit.net com outros frameworks****

https://xunit.net/docs/comparisons


# Considerações gerais sobre TDD

- Testes evitam que o sistema regrida, ou seja, economiza muito tempo nos testes de regressão
- Você recebe um alerta quando quebra algum comportamento existente ainda enquanto está trabalhando com o código, ou seja, menos bugs escapando
- Testes melhoram o seu código
- Testes automatizados apoiam refatoração
- Use para design de suas classes. Ciclo TDD  (Test-Driven-Design) - Teste >> correção >> refatoração
- Testes documentam comportamentos do sistema: qualquer comportamento deve ser traduzido em testes, inclusive as exceções.
- Uma documentação atualizada permite que novos contratados acelerem o processo de entendimento do código


## Boas práticas para escrever testes de unidade

https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices 
