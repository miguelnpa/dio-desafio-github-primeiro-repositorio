# Programando com orientação à objetos com C#
## Introdução

## Conhecendo a Programação Orientada a Objetos

Técnica de programação para um fim específico
Quatro pilares: 
Abstração, Encapsulamento, Herança, Polimorfismo
"Abstração de algo do mundo real na programação"

"A classe nada mais é do que um molde" - Nem todas as caracteristicas de um objeto precisam ser colocadas se não fizer sentido. 

### Tipos de paradigmas
Um paradigma nada mais é do que um modelo de técnicas, estruturas e formas de solucionar um problema.
Uma linguagem de programação implementa um ou mais paradigmas.

* Programação orientada a objetos
* Programação estruturada
* Programação imperativa
* Programação procedural
* Programação orientada a eventos 
* Programação Lógica

## Abstração 

Pegar um "objeto" do mundo real, para um contexto específico considerando apenas os atributos importantes.

## Encapsulamento

Encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades. Serve para ocultar seu comportamento e expor somente o necessário. (exemplo de conta corrente e não mudança de seu saldo em qualquer operação.)

## Herança

A Herança permite reutilizar atributos, métodos e comportamentos de uma classe em outras classe. 
Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes. 

class Aluno : Pessoa ( Esse dois pontos quer dizer que Aluno herda propriedades da classe Pessoa)

## Polimorfismo

O polimorfismo vem do grego e significa "Muitas formas".

Com o polimorfismo, podemos sobresescrever métodos das classes dilhas para que se comportem de maneira diferente e ter sua própria implementação.
Ao criar uma classe, se eu colocar "Virtual" significa que determinado método pode ser sobreescrito, e ao sobreescrever esse método numa classe filha eu coloco override
Ex.: public virtual void Apresentar() {}
     public override void Apresentar() {}

## Classes abstratas

Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdade, portanto não pode ser instanciada.

Você pode implementar métodos ou dexa-los a cargo de quem herdar

## Classes seladas

Uma classe selada tem como objetivo de impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada. 

Também existem métodos e propriedade seladas.

Na aula, é usado o exemplo da classe Pessoa => professor => e a classe Diretor tentando ser filha da classe professor, mas a classe professor é selada e não permite isso.

## Classes Object

A classe Sustem.Object é a mãe de todas as classes na hierarquia do .NET

Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

## Interfaces

Uma interface é um contrato que pode ser implementado por uma classe 

É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.

Assim como uma classe abstrata, uma interface não pode ser instanciada.

(A interface veio para fazer algo como herança múltipla.)

Para a classe que implementa uma interface, ela tem que implementar todos os métodos da interface ( caso a interface não possua implementação padrão.)

## Manipulando arquivos

O C# apresenta alguams classes estáticas que facilitam o trabalho com arquivos, dentre elas: 

File - Serve para manipular arquivos (criar, ler,mover, apagar)
Directory - listar diretórios, criar diretórios, Obter informação de diretórios
Path - Serve para organizar os caminhos de mateira lógica para trabalhar com File e Directory.

Path.combine são um conjunto de objeto/método que ajudam na criação de diretórios.

