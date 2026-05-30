using ClubeDaLeituraWeb.WebApp.Compartilhado.Dominio;
using ClubeDaLeituraWeb.WebApp.ModuloCaixa.Dominio;

public class Revista : EntidadeBase<Revista>
{
    public string Titulo { get; set; } = string.Empty;
    public int NumeroDaEdicao { get; set; } = 0;
    public int AnoDePublicacao { get; set; }
    public Caixa Caixa { get; set; } = null!;


    public Revista(string titulo, int numeroDaEdicao, int anoDePublicacao, Caixa caixa)
    {
        Titulo = titulo;
        NumeroDaEdicao = numeroDaEdicao;
        AnoDePublicacao = anoDePublicacao;
        Caixa = caixa;
    }

    public override void AtualizarDados(Revista revistaAtualizada)
    {
        Titulo = revistaAtualizada.Titulo;
        NumeroDaEdicao = revistaAtualizada.NumeroDaEdicao;
        AnoDePublicacao = revistaAtualizada.AnoDePublicacao;
        Caixa = revistaAtualizada.Caixa;
    }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Titulo))
            erros.Add("O campo Titulo é obrigatorio");

        if (int.IsNegative(NumeroDaEdicao))
            erros.Add("O campo Numero De Edição é obrigatorio!");

        if (int.IsNegative(AnoDePublicacao))
            erros.Add("O campo Ano De Publicação é obrigatorio");

        if (Caixa == null)
            erros.Add("esta revista não etem uma Caixa asociada a ela!");

        return erros;
    }
}
