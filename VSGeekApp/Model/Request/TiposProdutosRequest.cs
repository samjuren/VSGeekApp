namespace VSGeekApp.Model.Request;

public class TiposProdutosRequest
{
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public string DescricaoProduto { get; set; }
    public string PrecoProduto { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
}