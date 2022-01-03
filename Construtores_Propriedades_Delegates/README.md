# Construtores, Propriedades, Delegates e Eventos em .NET

## Construtores
### Construtor na prática
Um construtor é um método especial, que contém o mesmo nome do seu tipo classe, e tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instanciação de um objeto

* Um construtor não possui um retorno.
* Um construtor padrão é sempre definido quando não declaramos nenhuma para sua classe.
* Uma classe pode ter mais de um construtor.

Um construtor dá os valores de uma classe a um objeto, podendo ser vazio, ou preenchido ao instanciar uma nova classe. Ele serve para definir valores de classe padrão para que a classe ou objeto já seja instanciado com eles. 

### Construtor padrão

Um construtor padrão é um construtor que não tem parâmetros e que toda classe tem um construtor padrão caso não seja definido um explicitamente.

Se eu apagar o construtor que não recebe parâmetros, obrigatoriamente ao instanciar uma classe eu terei que dar os parâmetros pedidos.

### Construtor privado

Tipo que construtor que não pode ser usado para fazer instancia do objeto

Não se pode ter uma instância de uma classe com o construtor privado

### Chamando o construtor da Herança

Quando quer se referir à classe mãe, se usa o nome reservado "base"

No caso de um classe que herda um construtor com a necessidade de dizer parâmetros. Eu posso dizer que os parâmetros que vou fazer referência vai ser dado também à base.
ex.: 
public Aluno(string nome, string sobrenome) : base(nome, sobrenome)



