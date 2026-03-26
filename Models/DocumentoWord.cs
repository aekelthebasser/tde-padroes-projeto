namespace GeradorDocumentos.Models;

public class DocumentoWord : IDocumento
{
    private string _conteudo;
    
    public DocumentoWord(string conteudo)
    {
        _conteudo = conteudo;
    }

    public string Gerar()
    {
        return $"[WORD] Gerando documento: {_conteudo}\n--- CONTEÚDO WORD ---\nword/document.xml\nConteúdo: {_conteudo}";
    }

    public string GetTipo() => "Microsoft Word Document (DOCX)";
    public string GetExtensao() => ".docx";
}