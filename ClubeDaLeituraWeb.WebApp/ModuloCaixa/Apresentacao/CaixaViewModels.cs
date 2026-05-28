using System.ComponentModel.DataAnnotations;

namespace ClubeDaLeituraWeb.WebApp.ModuloCaixa.Apresentacao;

public record ListarCaixasViewModel(
    string Id,
    string Cor,
    string Etiqueta,
    int DiasDeEmprestimo
);

public record CadastrarCaixaViewModel(
    [Required(ErrorMessage = "O campo \"Etiqueta\" deve ser preenchido.")]
    [StringLength(50, ErrorMessage = "Ocampo \"Eiqueta\" deve conter no maximo 50 caracteres.")]
    string Etiqueta,

    [Required(ErrorMessage = "O campo \"Cor\" deve ser preenchido.")]
    string Cor,

    [Range(1, int.MaxValue, ErrorMessage = "O campo \"Dias de Emprestimo\" deve conter um valor maisr que 1")]
    int DiasDeEmprestimo
);

public record ExcluirCaixaViewModel(
    string Id,
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);

public record EditarCaixaViewModel(
    string Id,
    string Etiqueta,
    string Cor,
    int DiasDeEmprestimo
);
