# Painel da Brigada

**Equipe:** 
- Arthur Gomes - RM 560771
- Luiz Silva - RM 560110
- Matheus Siroma - RM 560248
- Pedro Estevam - RM 560642

Projeto da disciplina **C# Software Development** da Global Solution FIAP 2026.2, com o tema **CitizenTech**.

## Problema escolhido

Incêndios grandes começam em áreas com muita vegetação seca acumulada. Uma forma de prevenção é a **queima prescrita**: a brigada queima de forma planejada pequenas áreas, antes da época de seca, para tirar esse combustível. Para isso, ela precisa organizar quais locais ainda precisam ser avaliados e queimados.

O **Painel da Brigada** é uma lista de tarefas da brigada. O coordenador faz login e vê os locais pendentes de queima em cards. Ele pode adicionar um novo local (nome, endereço e tamanho da área) ou excluir um local da lista. O sistema classifica cada local pelo porte:

| Tamanho da área | Porte |
| --- | --- |
| até 10 ha | Pequeno |
| acima de 10 e até 50 ha | Médio |
| acima de 50 ha | Grande |

> Os dados ficam apenas na memória e se perdem ao fechar o sistema. Os exemplos usados são fictícios.

## Pessoa real beneficiada

O projeto é voltado para as **pessoas que vivem perto de áreas de vegetação seca**, como Cerrado, Pantanal e campos naturais: famílias da zona rural, pequenos produtores e moradores de cidades vizinhas. São elas que mais sofrem quando um incêndio sai do controle. A fumaça piora a respiração de idosos, crianças e de quem tem asma ou bronquite, e o fogo pode atingir casas, pastos, criações e plantações.

A queima prescrita protege essas pessoas antes que o problema aconteça. Quando a brigada queima pequenas áreas de forma planejada, a vegetação seca acumulada diminui, e um incêndio que começar depois encontra menos combustível: fica menor, gera menos fumaça e é mais fácil de controlar.

O Painel da Brigada reúne esses locais numa única tela, com endereço, tamanho da área e porte de cada um. Assim, a brigada sabe o que ainda falta fazer e começa pelas áreas maiores. Cada queima planejada que sai do papel é uma comunidade com menos risco de enfrentar um incêndio de grandes proporções.


## Instruções de execução

1. Abra o arquivo `PainelBrigada.sln` no **Visual Studio 2026** com o **.NET 10** instalado.
2. Aperte **F5**.
3. Entre com o acesso de teste: usuário `admin`, senha `admin`.

## Estrutura

| Pasta | Conteúdo |
| --- | --- |
| `Models` | `LocalQueima`: dados do local, validações e cálculo do porte. |
| `Services` | `AutenticacaoService`: login do sistema. |
| `Forms` | Telas: `FormLogin`, `FormQueimas` (cards) e `FormNovoLocal`. |

## Tecnologias

- C#
- .NET 10 (LTS)
- Windows Forms
- Git e GitHub
