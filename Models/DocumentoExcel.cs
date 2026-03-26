namespace GeradorDocumentos.Models;

public class DocumentoExcel : IDocumento
{
    private string _conteudo;
    
    public DocumentoExcel(string conteudo)
    {
        _conteudo = conteudo;
    }

    public string Gerar()
    {
        return $"[EXCEL] Gerando documento: {_conteudo}\n--- CONTEÚDO EXCEL ---\n<workbook><sheet>{_conteudo}</sheet></workbook>";
    }

    public string GetTipo() => "Microsoft Excel Spreadsheet (XLSX)";
    public string GetExtensao() => ".xlsx";
}