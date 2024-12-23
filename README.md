# Sistema de Gerenciamento de Cursos

## Sobre o Projeto

Este projeto explora conceitos básicos de programação orientada a objetos (POO) em C#, simulando um sistema simples de gerenciamento de cursos e alunos.

## Estrutura do Projeto

- **`Curso`**:
  - Gerencia alunos matriculados.
  - Métodos: adicionar, remover, listar alunos e obter quantidade de matriculados.

- **`Pessoa`**:
  - Representa os alunos.
  - Atributos: nome, sobrenome, idade, nome completo.
  - Método: apresentar informações do aluno.

## Exemplo de Uso

```csharp
Curso curso = new Curso { Nome = "C# Básico", Alunos = new List<Pessoa>() };
Pessoa aluno = new Pessoa("Maria", "Souza") { Idade = 22 };
curso.AdicionarAluno(aluno);
curso.ListarAlunos();
```

## Requisitos

- .NET 6.0+
- IDE compatível com C#
