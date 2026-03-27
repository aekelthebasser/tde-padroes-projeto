// ============================================
// VERSÃO VIOLADA - NÃO USA FACTORY METHOD
// Violações: SRP, OCP, DIP
// ============================================

using System;
using GeradorDocumentos.Models;

namespace GeradorDocumentos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GERADOR DE DOCUMENTOS (VERSÃO VIOLADA) ===\n");

        var conteudo = "Relatório TDE - Princípios SOLID";
        var tipos = new[] { "pdf", "word", "excel" };

        foreach (var tipo in tipos)
        {
            // VIOLA OCP: toda vez que adicionar um novo tipo,
            // esse if/else precisa ser modificado!
            if (tipo == "pdf")
            {
                var pdf = new DocumentoPDF(conteudo);
                Console.WriteLine(pdf.Gerar());
                Console.WriteLine($"Tipo: {pdf.GetTipo()}");
                Console.WriteLine($"Extensão: {pdf.GetExtensao()}");
            }
            else if (tipo == "word")
            {
                var word = new DocumentoWord(conteudo);
                Console.WriteLine(word.Gerar());
                Console.WriteLine($"Tipo: {word.GetTipo()}");
                Console.WriteLine($"Extensão: {word.GetExtensao()}");
            }
            else if (tipo == "excel")
            {
                var excel = new DocumentoExcel(conteudo);
                Console.WriteLine(excel.Gerar());
                Console.WriteLine($"Tipo: {excel.GetTipo()}");
                Console.WriteLine($"Extensão: {excel.GetExtensao()}");
            }
            
            Console.WriteLine("---\n");
        }
    }
}