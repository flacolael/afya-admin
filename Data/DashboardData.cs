namespace afya_admin.Data;

public static class DashboardData
{
    public static List<KpiData> Kpis =>
    [
        new()
        {
            Titulo = "Receita",
            Valor = "R$ 128,4 mil",
            Variacao = "+12,5%",
            VariacaoPositiva = true,
            Tendencia = [42, 48, 45, 53, 51, 62, 68, 74]
        },

        new()
        {
            Titulo = "Alunos ativos",
            Valor = "2.847",
            Variacao = "+8,2%",
            VariacaoPositiva = true,
            Tendencia = [38, 42, 40, 48, 51, 55, 61, 67]
        },

        new()
        {
            Titulo = "Projetos",
            Valor = "24",
            Variacao = "+4,3%",
            VariacaoPositiva = true,
            Tendencia = [25, 31, 29, 35, 38, 36, 42, 45]
        },

        new()
        {
            Titulo = "Taxa de conclusão",
            Valor = "87,4%",
            Variacao = "+5,7%",
            VariacaoPositiva = true,
            Tendencia = [58, 61, 60, 67, 69, 74, 78, 82]
        }
    ];

    public static List<ProjetoData> Projetos =>
    [
        new()
        {
            Nome = "Portal do Aluno",
            Responsavel = "Ana Souza",
            Progresso = 92,
            Status = "Concluído"
        },

        new()
        {
            Nome = "Sistema Acadêmico",
            Responsavel = "Carlos Lima",
            Progresso = 74,
            Status = "Em andamento"
        },

        new()
        {
            Nome = "App Pedagógico",
            Responsavel = "Marina Costa",
            Progresso = 58,
            Status = "Em andamento"
        },

        new()
        {
            Nome = "Dashboard BI",
            Responsavel = "João Silva",
            Progresso = 41,
            Status = "Em andamento"
        }
    ];

    public static List<AtividadeData> Atividades =>
    [
        new()
        {
            Usuario = "Ana Souza",
            Acao = "concluiu o projeto Portal do Aluno",
            Data = "Hoje, 10:42",
            Icone = "CheckCircle"
        },

        new()
        {
            Usuario = "Carlos Lima",
            Acao = "atualizou o Sistema Acadêmico",
            Data = "Hoje, 09:18",
            Icone = "Edit"
        },

        new()
        {
            Usuario = "Marina Costa",
            Acao = "adicionou uma nova atividade",
            Data = "Ontem, 16:35",
            Icone = "AddTask"
        },

        new()
        {
            Usuario = "João Silva",
            Acao = "enviou um relatório",
            Data = "Ontem, 14:20",
            Icone = "Description"
        }
    ];
}
