using SQLite;

namespace VSGeekApp.Database.Models;

public class TiposProdutos
{
    [PrimaryKey]
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
}