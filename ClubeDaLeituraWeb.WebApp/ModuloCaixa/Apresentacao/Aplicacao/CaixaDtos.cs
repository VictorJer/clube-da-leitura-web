namespace ClubeDaLeituraWeb.WebApp.ModuloCaixa.Aplicacao;


public record ListarCaixaDto(
    string Id,
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);

public record CadastrarCaixaDto(
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);

public record EditarCaixaDto(
    string Id,
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);

public record DetalhesCaixaDto(
    string Id,
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);
