Chain of Responsibility - C#

📚 Sobre o Projeto

Este projeto tem como objetivo estudar e praticar o padrão de projeto comportamental Chain of Responsibility (Cadeia de Responsabilidade) utilizando a linguagem C#.

O exemplo simula um sistema de aprovação de compras de uma empresa, onde diferentes responsáveis possuem limites de aprovação.

Cada responsável analisa a solicitação e, caso não tenha autoridade para aprová-la, encaminha para o próximo responsável da cadeia.

🎯 Objetivo

Compreender como distribuir responsabilidades entre diferentes objetos, evitando que uma única classe concentre todas as regras de aprovação.

💡 Exemplo do Projeto

O sistema possui três níveis de aprovação:

Responsável

Limite de aprovação

Gerente

Até R$ 500,00

Diretor

Até R$ 5.000,00

Presidente

Acima de R$ 5.000,00

Fluxo de aprovação

A solicitação chega ao Gerente.

Se estiver dentro do limite, o Gerente aprova.

Caso contrário, encaminha ao Diretor.

Se ultrapassar o limite do Diretor, encaminha ao Presidente.

O Presidente analisa a solicitação final.

🏗️ Estrutura do Projeto

ChainOfResponsibility/
│
├── Aprovador.cs
│
├── Gerente.cs
│
├── Diretor.cs
│
├── Presidente.cs
│
└── Program.cs

Responsabilidade das Classes

Aprovador: classe abstrata que define a estrutura dos aprovadores e permite configurar o próximo responsável.

Gerente: responsável por aprovar compras de até R$ 500,00.

Diretor: responsável por aprovar compras acima de R$ 500,00 até R$ 5.000,00.

Presidente: responsável pelas compras acima de R$ 5.000,00.

Program: responsável por instanciar os objetos, montar a cadeia e enviar as solicitações.

⚙️ Conceitos praticados

Programação Orientada a Objetos (POO).

Classes abstratas.

Herança.

Polimorfismo.

Encapsulamento.

Composição entre objetos.

Padrões de projeto comportamentais.

🚀 Tecnologias utilizadas

C#

.NET

Visual Studio


📖 Referência

Refactoring Guru - Chain of Responsibility