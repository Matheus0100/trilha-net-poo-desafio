# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
Este desafio de POO foi solucionado por meio dos conhecimentos adquiridos a respeito dos pilares da Orientação a Objetos. Por meio destes, pode-se abstrair objetos da vida real para a criação de Apps, como também reutilizar o código por meio da herança, tal qual se adequar as diferentes necessidades com a utilização do conceito de Polimorfismo. Também implementamos uma maior segurança ao nosso sistema ao utilizar do conceito de Encapsulamento, que restringe as modificações às classes, fazendo com que os dados não possam ser alterados fora dos métodos da respectiva classe.
