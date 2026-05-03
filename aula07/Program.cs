using System;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var produtos = new List<Produto>();

app.MapGet("/", () => "API funcionando!");

app.MapGet("/produtos", () => produtos);

app.MapPost("/produtos", (Produto p) =>
{
    produtos.Add(p);
    return Results.Ok(produtos);
});

app.MapGet("/produtos/{nome}", (string nome) =>
{
    foreach (var p in produtos)
    {
        if (p.Nome.ToLower() == nome.ToLower())
        {
            return Results.Ok(p);
        }
    }

    return Results.NotFound("Produto não encontrado");
});

app.Run();

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}