namespace GeradorDocumentos.Models;

public interface IDocumento
{
    string Gerar();
    string GetTipo();
    string GetExtensao();
}