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

## Interfaces

## Manipulando arquivos

