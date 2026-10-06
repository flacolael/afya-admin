# Afya Pedagógico — Dashboard Administrativo

## Identificação
- **Aluno:** Lael Veiga
- **Curso:** Bacharelado em Ciência da Computação
- **Instituição:** São Lucas / Afya
- **Matrícula:** PREENCHER
- **Disciplina:** PREENCHER
- **Professor(a):** PREENCHER

## Objetivo
Desenvolver um dashboard administrativo responsivo para visualizar indicadores acadêmicos, receita, distribuição de clientes, desempenho de projetos e atividades recentes.

## Tecnologias
- C#
- .NET 10
- Blazor WebAssembly
- MudBlazor
- Razor
- Git e GitHub

## Como executar
Requisitos: SDK .NET 10 instalado.

\`\`\`bash
git clone URL_DO_REPOSITORIO
cd afya-admin
dotnet restore
dotnet watch
\`\`\`

## Funcionalidades
- Menu lateral e barra superior.
- Tema claro e escuro.
- Cards de indicadores com tendências.
- Gráficos de receita e distribuição de clientes.
- Tabela de projetos com progresso e status.
- Lista de atividades recentes.
- Seletor de período.
- Dados fictícios.

## Estrutura
- `Components/`: componentes reutilizáveis.
- `Data/`: modelos e dados fictícios.
- `Layout/`: layout e navegação.
- `Pages/`: páginas da aplicação.
- `wwwroot/`: arquivos estáticos.

## Componentes
| Componente | Responsabilidade |
|---|---|
| KpiCard | Exibir indicadores e tendências. |
| DashboardCard | Padronizar cartões. |
| SeletorPeriodo | Selecionar o período. |
| MainLayout | Definir layout e tema. |
| NavMenu | Exibir navegação. |
| Dashboard | Organizar os elementos do painel. |

## Capturas de tela
Adicionar capturas reais do tema claro, tema escuro, versão mobile e DevTools na pasta `docs/`.

## O que aprendi
Responda às perguntas abaixo com suas próprias palavras.

1. O que é Blazor WebAssembly? **PREENCHER**
2. Qual é a função do MudBlazor? **PREENCHER**
3. Por que dividir a interface em componentes? **PREENCHER**
4. Para que servem os parâmetros de um componente? **PREENCHER**
5. Como funciona a alternância entre tema claro e escuro? **PREENCHER**
6. Como o layout se adapta a diferentes tamanhos de tela? **PREENCHER**
7. Qual é a função dos modelos e dados fictícios? **PREENCHER**
8. Como Git e commits ajudam no desenvolvimento? **PREENCHER**

## Dificuldades e soluções
- Compatibilidade com MudBlazor 9: ajustes nos parâmetros dos gráficos.
- Organização da interface: separação de componentes, layout, páginas e dados.

## Melhorias futuras
- Integrar API e banco de dados.
- Implementar autenticação e permissões.
- Tornar a busca funcional.
- Conectar o período selecionado aos gráficos.
- Implementar as demais páginas do menu.
