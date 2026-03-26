using GeradorDocumentos.Models;

namespace GeradorDocumentos.Factory;

public static class DocumentoFactory
{
    public static IDocumento CriarDocumento(string tipo, string conteudo)
    {
        return tipo.ToLower() switch
        {
            "pdf" => new DocumentoPDF(conteudo),
            "word" => new DocumentoWord(conteudo),
            "excel" => new DocumentoExcel(conteudo),
            _ => throw new ArgumentException($"Tipo '{tipo}' não suportado")
        };
    }
}