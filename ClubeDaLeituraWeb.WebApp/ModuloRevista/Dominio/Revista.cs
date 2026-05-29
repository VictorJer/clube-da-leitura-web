using ClubeDaLeituraWeb.WebApp.Compartilhado.Dominio;
using ClubeDaLeituraWeb.WebApp.ModuloCaixa.Dominio;

public class Revista : EntidadeBase<Revista>
{
    public string Titulo { get; set; } = string.Empty;
    public int NumeroDaEdicao { get; set; } = 0;
    public int AnoDePublicação { get; set; }
    public Caixa caixa { get; set; } = null!;

    public override void AtualizarDados(Revista EntidadeBase)
    {
        throw new NotImplementedException();
    }

    public override List<string> Validar()
    {
        throw new NotImplementedException();
    }
}
