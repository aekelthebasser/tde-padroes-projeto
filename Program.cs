using GeradorDocumentos.Factory;

namespace GeradorDocumentos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GERADOR DE DOCUMENTOS ===\n");

        var conteudo = "Relatório TDE - Princípios SOLID";
        var tipos = new[] { "pdf", "word", "excel" };

        foreach (var tipo in tipos)
        {
            var documento = DocumentoFactory.CriarDocumento(tipo, conteudo);
            Console.WriteLine(documento.Gerar());
            Console.WriteLine($"Tipo: {documento.GetTipo()}");
            Console.WriteLine($"Extensão: {documento.GetExtensao()}");
            Console.WriteLine("---\n");
        }
    }
}