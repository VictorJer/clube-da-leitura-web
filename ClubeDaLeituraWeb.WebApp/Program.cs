using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorOptions((options) =>
{
    // Resetar a configu padrão do MVC
    options.ViewLocationFormats.Clear();

    // Views dos módulos: /ModuloCaixa/Apresentacao/Views/Listar.cshtml
    options.ViewLocationFormats.Add("/Modulo{1}/Apresentacao/Views/{0}.cshtml");

    // Views dos módulos: /Compartilhado/Apresentacao/Views/_Layout.cshtml
    options.ViewLocationFormats.Add("/Compartilhado/Apresentacao/Views/{0}.cshtml");
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
