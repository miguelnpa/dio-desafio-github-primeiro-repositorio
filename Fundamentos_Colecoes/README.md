# Fundamentos de Coleções e LINQ com .NET

## ARRAYS
### Etapa 1
O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.
int[] array = new int[4];
int[] array = new inst[]{42,75,74,61};
string[] nomes = {"Jan","Fev"};
A capacidade do Array é definida no momento que ele é criado

O array pode possuir mais de uma dimensão:
int[,] array = new int[4,2];

4 = Números de linhas
2 = Número de colunas

Acessar um valor: array [1,1]

## Manipulando Arrays
### Algoritmos de ordenação

Quando passamos um array como referência, nos trabalhamos com a mesma variável passada, sem criar uma nova. 

### A classe Array

A classe Array é uma classe do C# que nos oferece diversos métodos que nos auxiliam a trabalhar com arrays.

## Coleções Genéricas
No C#, existem classes de coleçõs que agrupam valores, e essas classes são padronizadas para as operações mais comuns, como: 
- Ordenação
- Obter valor por índice
- Obter valor com expressões
- Trabalhar com tamanhos dinâmicos

Pode-se criar uma coleção genérica usando uma das classes do namespace System.Colletions.Generic

## Coleções específicas

As coleções específicas implementam regras para sua ordem de acesso e manipulação de seus elementos, são elas: 

QUEUE(File): Obedece a ordem FIFO ( First in First Out)
STACK (Pilha): Obedece a ordem LIFO ( Last in First Out)

## Dicíonários

Um dicionário é uma coleção de chave e valor, permitindo que você recupera rapidamente seus itens baseado em sua chave.
O dicionários armazena a sua chave em hash ( quando precisa recuperar algum elemento do dicionários, será passada a chave e por isso a busca será mais performática.)

Dictionary<string,string> estados = new Dictionary <string, string>()

## Operações LINQ

O language - integrated Query( LINQ) é uma maneira de você utilizar uma sintaxe de consulta padronizada para coleções de objetos.