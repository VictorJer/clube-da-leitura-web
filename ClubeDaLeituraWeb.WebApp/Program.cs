using ClubeDaLeituraWeb.WebApp.Compartilhado.Infra.Arquivos;
using ClubeDaLeituraWeb.WebApp.ModuloCaixa.Dominio;
using ClubeDaLeituraWeb.WebApp.ModuloCaixa.Infra.Repositorio;


var builder = WebApplication.CreateBuilder(args);

#region Configuraçâo de Serviço de Infraestrutura

builder.Services.AddScoped<ContextoJson>(provider =>
{
    ContextoJson contextoJson = new ContextoJson();

    contextoJson.Carregar();

    return contextoJson;
});

builder.Services.AddScoped<IRepositorioCaixa, RepositorioCaixaEmArquivo>();

#endregion

#region Configuração de MVC

builder.Services.AddControllersWithViews().AddRazorOptions((options) =>
{
    // Resetar a configu padrão do MVC
    options.ViewLocationFormats.Clear();

    // Views dos módulos: /ModuloCaixa/Apresentacao/Views/Listar.cshtml
    options.ViewLocationFormats.Add("/Modulo{1}/Apresentacao/Views/{0}.cshtml");

    // Views dos módulos: /Compartilhado/Apresentacao/Views/_Layout.cshtml
    options.ViewLocationFormats.Add("/Compartilhado/Apresentacao/Views/{0}.cshtml");
});

#endregion

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
