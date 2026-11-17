# Painel da Brigada

**Equipe:** _(preencher com o nome da equipe)_

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

_(preencher: nome, função e brigada do brigadista entrevistado pela equipe, e o que ele contou sobre o problema)_

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
