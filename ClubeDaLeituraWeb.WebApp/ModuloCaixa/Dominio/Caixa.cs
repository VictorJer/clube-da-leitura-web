using System.Net.NetworkInformation;
using ClubeDaLeituraWeb.WebApp.Compartilhado.Dominio;

namespace ClubeDaLeituraWeb.WebApp.ModuloCaixa.Dominio;

public sealed class Caixa : EntidadeBase<Caixa>
{
    public string Etiqueta { get; set; } = string.Empty;
    public string Cor { get; set; } = string.Empty;
    public int DiasDeEmprestimo { get; set; } = 7;

    public Caixa(string etiqueta, string cor, int diasDeEmprestimo)
    {
        Etiqueta = etiqueta;
        Cor = cor;
        DiasDeEmprestimo = diasDeEmprestimo;
    }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Etiqueta))
            erros.Add("A etiqueta da caixa é obrigatória.");

        if (string.IsNullOrEmpty(Cor))
            erros.Add("A cor da caixa é obrigatória.");

        if (DiasDeEmprestimo <= 0)
            erros.Add("Os dias de empréstimo devem ser maiores que zero.");

        return erros;
    }

    public override void AtualizarDados(Caixa caixaAtualizada)
    {
        Etiqueta = caixaAtualizada.Etiqueta;
        Cor = caixaAtualizada.Cor;
        DiasDeEmprestimo = caixaAtualizada.DiasDeEmprestimo;
    }
}

