# Afya Pedagógico — Sistema Acadêmico

## Identificação

- **Aluno:** Lael Veiga
- **Curso:** Bacharelado em Ciência da Computação
- **Instituição:** São Lucas / Afya
- **Disciplina:** Desenvolvimento Web
- **Projeto:** Afya Pedagógico

## Sobre o projeto

O **Afya Pedagógico** é uma aplicação web desenvolvida com Blazor WebAssembly e MudBlazor para simular um sistema administrativo acadêmico.

A aplicação apresenta um dashboard com indicadores gerais e páginas destinadas ao gerenciamento e acompanhamento de informações acadêmicas, utilizando dados fictícios para demonstração.

O projeto foi desenvolvido com foco em organização de componentes, reutilização de código, responsividade e utilização de uma interface baseada no Material Design.

## Tecnologias utilizadas

- C#
- .NET 10
- Blazor WebAssembly
- MudBlazor
- Razor
- Git
- GitHub

## Funcionalidades

### Dashboard

- Indicadores acadêmicos em cards;
- Gráficos e visualizações de dados;
- Atividades recentes;
- Informações resumidas do sistema;
- Seletor de período;
- Tema claro e escuro.

### Gestão acadêmica

- **Alunos:** visualização de alunos cadastrados, situação e curso;
- **Professores:** informações do corpo docente;
- **Cursos:** cursos disponíveis, modalidade, duração e quantidade de alunos;
- **Notas:** acompanhamento do desempenho acadêmico;
- **Relatórios:** indicadores e relatórios disponíveis;
- **Configurações:** configurações gerais da aplicação.

> Os dados utilizados na aplicação são fictícios e têm finalidade exclusivamente demonstrativa.

## Estrutura do projeto

```text
afya-admin/
├── Components/
│   └── Componentes reutilizáveis
├── Data/
│   └── Dados e modelos utilizados pela aplicação
├── Layout/
│   └── Layout principal e navegação
├── Pages/
│   └── Páginas da aplicação
├── wwwroot/
│   └── Arquivos estáticos
├── App.razor
└── Program.cs
