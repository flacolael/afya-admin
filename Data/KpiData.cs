namespace afya_admin.Data;

public class KpiData
{
    public string Titulo { get; set; } = string.Empty;
    public string Valor { get; set; } = string.Empty;
    public string Variacao { get; set; } = string.Empty;
    public bool VariacaoPositiva { get; set; }
    public double[] Tendencia { get; set; } = [];
}
