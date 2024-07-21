# FactoryMethod

O padrão de projeto Factory Method fornece uma interface para criar objetos em uma superclasse, 
permitindo que as subclasses alterem o tipo de objeto que será criado.

O padrão Factory Method sugere que você substitua chamadas diretas de construção de objetos (usando o operador new) por chamadas para um método fábrica especial. 
Os objetos ainda são criados através do operador new, mas esse está sendo chamado de dentro do método fábrica. 
Objetos retornados por um método fábrica geralmente são chamados de produtos.

Estrutura:

![image](https://github.com/user-attachments/assets/90b06027-3492-442f-bdaa-347909a5cdf9)

