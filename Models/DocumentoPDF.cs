namespace GeradorDocumentos.Models;

public class DocumentoPDF : IDocumento
{
    private string _conteudo;
    
    public DocumentoPDF(string conteudo)
    {
        _conteudo = conteudo;
    }

    public string Gerar()
    {
        return $"[PDF] Gerando documento: {_conteudo}\n--- CONTEÚDO PDF ---\n%PDF-1.4\nConteúdo: {_conteudo}";
    }

    public string GetTipo() => "Portable Document Format (PDF)";
    public string GetExtensao() => ".pdf";
}